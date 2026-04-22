using DataPilot;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
// Alias to avoid Font conflict
using iTextFont = iTextSharp.text.Font;

namespace DataPilot
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // No automatic load – grid stays empty until user clicks "Load Data"
        }

        private void LoadData()
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                string query = "SELECT id, name, description, price, quantity FROM products";
                DataTable dt = db.ExecuteQuery(query);
                dgvData.DataSource = dt;

                // Set column headers
                if (dgvData.Columns.Contains("id"))
                    dgvData.Columns["id"].HeaderText = "ID";
                if (dgvData.Columns.Contains("name"))
                    dgvData.Columns["name"].HeaderText = "Product Name";
                if (dgvData.Columns.Contains("description"))
                    dgvData.Columns["description"].HeaderText = "Description";
                if (dgvData.Columns.Contains("price"))
                    dgvData.Columns["price"].HeaderText = "Price ($)";
                if (dgvData.Columns.Contains("quantity"))
                    dgvData.Columns["quantity"].HeaderText = "Quantity";

                // Fill the entire grid area
                dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                lblStatus.Text = $"Loaded {dt.Rows.Count} records.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        // ========== BUTTON EVENT HANDLERS ==========
        private void btnLoadData_Click(object sender, EventArgs e) => LoadData();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.IsEditMode = false;
            if (productForm.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null)
            {
                MessageBox.Show("Select a row to edit.");
                return;
            }

            int id = Convert.ToInt32(dgvData.CurrentRow.Cells["id"].Value);
            ProductForm productForm = new ProductForm();
            productForm.IsEditMode = true;
            productForm.ProductId = id;

            if (productForm.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null)
            {
                MessageBox.Show("Select a row to delete.");
                return;
            }

            int id = Convert.ToInt32(dgvData.CurrentRow.Cells["id"].Value);
            DialogResult res = MessageBox.Show("Delete this product permanently?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                DatabaseHelper db = new DatabaseHelper();
                string query = "DELETE FROM products WHERE id = @id";
                MySqlParameter[] parameters = { new MySqlParameter("@id", id) };
                int rows = db.ExecuteNonQuery(query, parameters);

                if (rows > 0)
                {
                    MessageBox.Show("Deleted.");
                    LoadData();
                }
                else
                    MessageBox.Show("Delete failed.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string term = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(term))
            {
                LoadData();
                return;
            }

            DatabaseHelper db = new DatabaseHelper();
            string query = "SELECT id, name, description, price, quantity FROM products WHERE name LIKE @term OR description LIKE @term";
            MySqlParameter[] parameters = { new MySqlParameter("@term", "%" + term + "%") };
            DataTable dt = db.ExecuteQuery(query, parameters);
            dgvData.DataSource = dt;
            lblStatus.Text = $"Found {dt.Rows.Count} records for '{term}'.";
        }

        // ========== EXPORT EXCEL ==========
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            ExcelPackage.License.SetNonCommercialPersonal("DataPilot User");

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel files|*.xlsx",
                DefaultExt = "xlsx",
                FileName = $"DataPilot_Products_{DateTime.Now:yyyyMMdd_HHmmss}"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (ExcelPackage pck = new ExcelPackage())
                    {
                        var ws = pck.Workbook.Worksheets.Add("Products");

                        // Headers
                        for (int i = 1; i <= dgvData.Columns.Count; i++)
                        {
                            ws.Cells[1, i].Value = dgvData.Columns[i - 1].HeaderText;
                            ws.Cells[1, i].Style.Font.Bold = true;
                        }

                        // Data rows
                        for (int row = 0; row < dgvData.Rows.Count; row++)
                        {
                            for (int col = 0; col < dgvData.Columns.Count; col++)
                            {
                                ws.Cells[row + 2, col + 1].Value = dgvData.Rows[row].Cells[col].Value?.ToString();
                            }
                        }

                        ws.Cells.AutoFitColumns();
                        pck.SaveAs(new FileInfo(sfd.FileName));
                    }
                    MessageBox.Show("Excel export completed.");
                }
            }
        }

        // ========== EXPORT PDF ==========
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "PDF files|*.pdf",
                DefaultExt = "pdf",
                FileName = $"DataPilot_Products_{DateTime.Now:yyyyMMdd_HHmmss}"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document document = new Document(PageSize.A4.Rotate());
                    PdfWriter.GetInstance(document, new FileStream(sfd.FileName, FileMode.Create));
                    document.Open();

                    iTextFont titleFont = FontFactory.GetFont(FontFactory.HELVETICA, 18, iTextFont.BOLD);
                    Paragraph title = new Paragraph("DataPilot - Product Report", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    document.Add(title);

                    iTextFont normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                    document.Add(new Paragraph($"Generated on: {DateTime.Now}", normalFont));
                    document.Add(new Paragraph(" "));

                    PdfPTable table = new PdfPTable(dgvData.Columns.Count);
                    table.WidthPercentage = 100;

                    iTextFont headerFont = FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextFont.BOLD);
                    foreach (DataGridViewColumn col in dgvData.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, headerFont));
                        cell.BackgroundColor = new BaseColor(240, 240, 240);
                        table.AddCell(cell);
                    }

                    iTextFont dataFont = FontFactory.GetFont(FontFactory.HELVETICA, 9);
                    foreach (DataGridViewRow row in dgvData.Rows)
                    {
                        if (row.IsNewRow) continue;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string value = cell.Value?.ToString() ?? "";
                            table.AddCell(new Phrase(value, dataFont));
                        }
                    }

                    document.Add(table);
                    document.Close();
                    MessageBox.Show("PDF export completed.");
                }
            }
        }

        // ========== REQUIRED EVENT HANDLERS (must exist to match designer) ==========
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional – can be left empty
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Optional – you can enable live search by uncommenting:
            // btnSearch_Click(sender, e);
        }

        // This method is not used in the current designer but kept for safety
        private void label1_Click(object sender, EventArgs e) { }
    }
}






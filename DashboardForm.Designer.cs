////namespace DataPilot
////{
////    partial class DashboardForm
////    {
////        /// <summary>
////        /// Required designer variable.
////        /// </summary>
////        private System.ComponentModel.IContainer components = null;

////        /// <summary>
////        /// Clean up any resources being used.
////        /// </summary>
////        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
////        protected override void Dispose(bool disposing)
////        {
////            if (disposing && (components != null))
////            {
////                components.Dispose();
////            }
////            base.Dispose(disposing);
////        }

////        #region Windows Form Designer generated code

////        /// <summary>
////        /// Required method for Designer support - do not modify
////        /// the contents of this method with the code editor.
////        /// </summary>
////        private void InitializeComponent()
////        {
////            this.dgvData = new System.Windows.Forms.DataGridView();
////            this.btnAdd = new System.Windows.Forms.Button();
////            this.btnExportExcel = new System.Windows.Forms.Button();
////            this.btnEdit = new System.Windows.Forms.Button();
////            this.btnDelete = new System.Windows.Forms.Button();
////            this.btnLoadData = new System.Windows.Forms.Button();
////            this.btnExportPDF = new System.Windows.Forms.Button();
////            this.txtSearch = new System.Windows.Forms.TextBox();
////            this.btnSearch = new System.Windows.Forms.Button();
////            this.lblStatus = new System.Windows.Forms.Label();
////            this.label2 = new System.Windows.Forms.Label();
////            this.panelTop = new System.Windows.Forms.Panel();
////            this.panelGrid = new System.Windows.Forms.Panel();
////            this.panel1 = new System.Windows.Forms.Panel();
////            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
////            this.panelTop.SuspendLayout();
////            this.panelGrid.SuspendLayout();
////            this.panel1.SuspendLayout();
////            this.SuspendLayout();
////            // 
////            // dgvData
////            // 
////            this.dgvData.AllowUserToAddRows = false;
////            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
////            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
////            this.dgvData.Location = new System.Drawing.Point(0, 0);
////            this.dgvData.Name = "dgvData";
////            this.dgvData.ReadOnly = true;
////            this.dgvData.Size = new System.Drawing.Size(1370, 554);
////            this.dgvData.TabIndex = 0;
////            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
////            // 
////            // btnAdd
////            // 
////            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
////            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
////            this.btnAdd.Location = new System.Drawing.Point(780, 68);
////            this.btnAdd.Name = "btnAdd";
////            this.btnAdd.Size = new System.Drawing.Size(128, 23);
////            this.btnAdd.TabIndex = 1;
////            this.btnAdd.Text = "Add ";
////            this.btnAdd.UseVisualStyleBackColor = false;
////            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
////            // 
////            // btnExportExcel
////            // 
////            this.btnExportExcel.BackColor = System.Drawing.Color.LimeGreen;
////            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.btnExportExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
////            this.btnExportExcel.Location = new System.Drawing.Point(413, 34);
////            this.btnExportExcel.Name = "btnExportExcel";
////            this.btnExportExcel.Size = new System.Drawing.Size(126, 23);
////            this.btnExportExcel.TabIndex = 2;
////            this.btnExportExcel.Text = "Excel";
////            this.btnExportExcel.UseVisualStyleBackColor = false;
////            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
////            // 
////            // btnEdit
////            // 
////            this.btnEdit.BackColor = System.Drawing.Color.Lime;
////            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
////            this.btnEdit.Location = new System.Drawing.Point(350, 68);
////            this.btnEdit.Name = "btnEdit";
////            this.btnEdit.Size = new System.Drawing.Size(126, 23);
////            this.btnEdit.TabIndex = 3;
////            this.btnEdit.Text = "Edit";
////            this.btnEdit.UseVisualStyleBackColor = false;
////            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
////            // 
////            // btnDelete
////            // 
////            this.btnDelete.BackColor = System.Drawing.Color.Red;
////            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
////            this.btnDelete.Location = new System.Drawing.Point(577, 68);
////            this.btnDelete.Name = "btnDelete";
////            this.btnDelete.Size = new System.Drawing.Size(126, 23);
////            this.btnDelete.TabIndex = 4;
////            this.btnDelete.Text = "Delete";
////            this.btnDelete.UseVisualStyleBackColor = false;
////            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
////            // 
////            // btnLoadData
////            // 
////            this.btnLoadData.BackColor = System.Drawing.Color.RoyalBlue;
////            this.btnLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.btnLoadData.ForeColor = System.Drawing.SystemColors.ButtonFace;
////            this.btnLoadData.Location = new System.Drawing.Point(577, 34);
////            this.btnLoadData.Name = "btnLoadData";
////            this.btnLoadData.Size = new System.Drawing.Size(126, 23);
////            this.btnLoadData.TabIndex = 5;
////            this.btnLoadData.Text = "Load Data";
////            this.btnLoadData.UseVisualStyleBackColor = false;
////            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
////            // 
////            // btnExportPDF
////            // 
////            this.btnExportPDF.BackColor = System.Drawing.Color.Red;
////            this.btnExportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.btnExportPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
////            this.btnExportPDF.Location = new System.Drawing.Point(744, 34);
////            this.btnExportPDF.Name = "btnExportPDF";
////            this.btnExportPDF.Size = new System.Drawing.Size(126, 23);
////            this.btnExportPDF.TabIndex = 6;
////            this.btnExportPDF.Text = "PDF";
////            this.btnExportPDF.UseVisualStyleBackColor = false;
////            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
////            // 
////            // txtSearch
////            // 
////            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.txtSearch.Location = new System.Drawing.Point(289, 118);
////            this.txtSearch.Name = "txtSearch";
////            this.txtSearch.Size = new System.Drawing.Size(187, 22);
////            this.txtSearch.TabIndex = 7;
////            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
////            // 
////            // btnSearch
////            // 
////            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
////            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
////            this.btnSearch.Location = new System.Drawing.Point(472, 118);
////            this.btnSearch.Name = "btnSearch";
////            this.btnSearch.Size = new System.Drawing.Size(126, 23);
////            this.btnSearch.TabIndex = 8;
////            this.btnSearch.Text = "Search";
////            this.btnSearch.UseVisualStyleBackColor = false;
////            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
////            // 
////            // lblStatus
////            // 
////            this.lblStatus.AutoSize = true;
////            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
////            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
////            this.lblStatus.Location = new System.Drawing.Point(415, 75);
////            this.lblStatus.Name = "lblStatus";
////            this.lblStatus.Size = new System.Drawing.Size(114, 37);
////            this.lblStatus.TabIndex = 9;
////            this.lblStatus.Text = "Status";
////            this.lblStatus.Click += new System.EventHandler(this.label1_Click);
////            // 
////            // label2
////            // 
////            this.label2.AutoSize = true;
////            this.label2.BackColor = System.Drawing.Color.Transparent;
////            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.label2.ForeColor = System.Drawing.Color.White;
////            this.label2.Location = new System.Drawing.Point(383, 0);
////            this.label2.Name = "label2";
////            this.label2.Size = new System.Drawing.Size(487, 55);
////            this.label2.TabIndex = 10;
////            this.label2.Text = "DataPilot Dashboard";
////            // 
////            // panelTop
////            // 
////            this.panelTop.BackColor = System.Drawing.Color.Transparent;
////            this.panelTop.Controls.Add(this.label2);
////            this.panelTop.Controls.Add(this.btnEdit);
////            this.panelTop.Controls.Add(this.btnDelete);
////            this.panelTop.Controls.Add(this.txtSearch);
////            this.panelTop.Controls.Add(this.btnSearch);
////            this.panelTop.Controls.Add(this.btnAdd);
////            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
////            this.panelTop.Location = new System.Drawing.Point(0, 0);
////            this.panelTop.Name = "panelTop";
////            this.panelTop.Size = new System.Drawing.Size(1370, 195);
////            this.panelTop.TabIndex = 11;
////            // 
////            // panelGrid
////            // 
////            this.panelGrid.Controls.Add(this.dgvData);
////            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
////            this.panelGrid.Location = new System.Drawing.Point(0, 195);
////            this.panelGrid.Name = "panelGrid";
////            this.panelGrid.Size = new System.Drawing.Size(1370, 554);
////            this.panelGrid.TabIndex = 12;
////            // 
////            // panel1
////            // 
////            this.panel1.BackColor = System.Drawing.Color.Transparent;
////            this.panel1.Controls.Add(this.btnExportExcel);
////            this.panel1.Controls.Add(this.btnExportPDF);
////            this.panel1.Controls.Add(this.lblStatus);
////            this.panel1.Controls.Add(this.btnLoadData);
////            this.panel1.Location = new System.Drawing.Point(0, 566);
////            this.panel1.Name = "panel1";
////            this.panel1.Size = new System.Drawing.Size(1441, 187);
////            this.panel1.TabIndex = 13;
////            // 
////            // DashboardForm
////            // 
////            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
////            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
////            this.BackColor = System.Drawing.SystemColors.Highlight;
////            this.BackgroundImage = global::DataPilot.Properties.Resources.Gemini_Generated_Image_d4er1rd4er1rd4er;
////            this.ClientSize = new System.Drawing.Size(1370, 749);
////            this.Controls.Add(this.panel1);
////            this.Controls.Add(this.panelGrid);
////            this.Controls.Add(this.panelTop);
////            this.Name = "DashboardForm";
////            this.Text = "DashboardForm";
////            this.Load += new System.EventHandler(this.DashboardForm_Load);
////            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
////            this.panelTop.ResumeLayout(false);
////            this.panelTop.PerformLayout();
////            this.panelGrid.ResumeLayout(false);
////            this.panel1.ResumeLayout(false);
////            this.panel1.PerformLayout();
////            this.ResumeLayout(false);

////        }

////        #endregion

////        private System.Windows.Forms.DataGridView dgvData;
////        private System.Windows.Forms.Button btnAdd;
////        private System.Windows.Forms.Button btnExportExcel;
////        private System.Windows.Forms.Button btnEdit;
////        private System.Windows.Forms.Button btnDelete;
////        private System.Windows.Forms.Button btnLoadData;
////        private System.Windows.Forms.Button btnExportPDF;
////        private System.Windows.Forms.TextBox txtSearch;
////        private System.Windows.Forms.Button btnSearch;
////        private System.Windows.Forms.Label lblStatus;
////        private System.Windows.Forms.Label label2;
////        private System.Windows.Forms.Panel panelTop;
////        private System.Windows.Forms.Panel panelGrid;
////        private System.Windows.Forms.Panel panel1;
////    }
////}



//namespace DataPilot
//{
//    partial class DashboardForm
//    {
//        private System.ComponentModel.IContainer components = null;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//                components.Dispose();

//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        private void InitializeComponent()
//        {
//            this.dgvData = new System.Windows.Forms.DataGridView();
//            this.btnAdd = new System.Windows.Forms.Button();
//            this.btnExportExcel = new System.Windows.Forms.Button();
//            this.btnEdit = new System.Windows.Forms.Button();
//            this.btnDelete = new System.Windows.Forms.Button();
//            this.btnLoadData = new System.Windows.Forms.Button();
//            this.btnExportPDF = new System.Windows.Forms.Button();
//            this.txtSearch = new System.Windows.Forms.TextBox();
//            this.btnSearch = new System.Windows.Forms.Button();
//            this.lblStatus = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();

//            this.panelTop = new System.Windows.Forms.Panel();
//            this.panelGrid = new System.Windows.Forms.Panel();
//            this.panelBottom = new System.Windows.Forms.Panel();

//            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
//            this.panelTop.SuspendLayout();
//            this.panelGrid.SuspendLayout();
//            this.panelBottom.SuspendLayout();
//            this.SuspendLayout();

//            // ================= GRID =================
//            this.dgvData.AllowUserToAddRows = false;
//            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.dgvData.ReadOnly = true;
//            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);

//            // ================= PANEL TOP =================
//            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
//            this.panelTop.Height = 150;
//            this.panelTop.BackColor = System.Drawing.Color.Transparent;

//            this.label2.Text = "DataPilot Dashboard";
//            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
//            this.label2.ForeColor = System.Drawing.Color.White;
//            this.label2.AutoSize = true;
//            this.label2.Location = new System.Drawing.Point(400, 10);

//            this.btnAdd.Text = "Add";
//            this.btnAdd.Location = new System.Drawing.Point(800, 80);
//            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

//            this.btnEdit.Text = "Edit";
//            this.btnEdit.Location = new System.Drawing.Point(350, 80);
//            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

//            this.btnDelete.Text = "Delete";
//            this.btnDelete.Location = new System.Drawing.Point(550, 80);
//            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

//            this.txtSearch.Location = new System.Drawing.Point(300, 120);
//            this.txtSearch.Width = 200;
//            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

//            this.btnSearch.Text = "Search";
//            this.btnSearch.Location = new System.Drawing.Point(520, 120);
//            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

//            this.panelTop.Controls.Add(this.label2);
//            this.panelTop.Controls.Add(this.btnAdd);
//            this.panelTop.Controls.Add(this.btnEdit);
//            this.panelTop.Controls.Add(this.btnDelete);
//            this.panelTop.Controls.Add(this.txtSearch);
//            this.panelTop.Controls.Add(this.btnSearch);

//            // ================= PANEL GRID =================
//            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.panelGrid.Controls.Add(this.dgvData);

//            // ================= PANEL BOTTOM =================
//            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
//            this.panelBottom.Height = 100;
//            this.panelBottom.BackColor = System.Drawing.Color.Transparent;

//            this.btnExportExcel.Text = "Excel";
//            this.btnExportExcel.Location = new System.Drawing.Point(350, 30);
//            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);

//            this.btnExportPDF.Text = "PDF";
//            this.btnExportPDF.Location = new System.Drawing.Point(500, 30);
//            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);

//            this.btnLoadData.Text = "Load Data";
//            this.btnLoadData.Location = new System.Drawing.Point(650, 30);
//            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);

//            this.lblStatus.Text = "Status";
//            this.lblStatus.ForeColor = System.Drawing.Color.White;
//            this.lblStatus.AutoSize = true;
//            this.lblStatus.Location = new System.Drawing.Point(850, 35);
//            this.lblStatus.Click += new System.EventHandler(this.label1_Click);

//            this.panelBottom.Controls.Add(this.btnExportExcel);
//            this.panelBottom.Controls.Add(this.btnExportPDF);
//            this.panelBottom.Controls.Add(this.btnLoadData);
//            this.panelBottom.Controls.Add(this.lblStatus);

//            // ================= FORM =================
//            this.ClientSize = new System.Drawing.Size(1370, 749);
//            this.Controls.Add(this.panelGrid);
//            this.Controls.Add(this.panelBottom);
//            this.Controls.Add(this.panelTop);

//            this.Text = "Dashboard";
//            this.Load += new System.EventHandler(this.DashboardForm_Load);

//            this.panelTop.ResumeLayout(false);
//            this.panelTop.PerformLayout();
//            this.panelGrid.ResumeLayout(false);
//            this.panelBottom.ResumeLayout(false);
//            this.panelBottom.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
//            this.ResumeLayout(false);
//        }

//        #endregion

//        private System.Windows.Forms.DataGridView dgvData;
//        private System.Windows.Forms.Button btnAdd;
//        private System.Windows.Forms.Button btnExportExcel;
//        private System.Windows.Forms.Button btnEdit;
//        private System.Windows.Forms.Button btnDelete;
//        private System.Windows.Forms.Button btnLoadData;
//        private System.Windows.Forms.Button btnExportPDF;
//        private System.Windows.Forms.TextBox txtSearch;
//        private System.Windows.Forms.Button btnSearch;
//        private System.Windows.Forms.Label lblStatus;
//        private System.Windows.Forms.Label label2;

//        private System.Windows.Forms.Panel panelTop;
//        private System.Windows.Forms.Panel panelGrid;
//        private System.Windows.Forms.Panel panelBottom;
//    }
//}



//namespace DataPilot
//{
//    partial class DashboardForm
//    {
//        private System.ComponentModel.IContainer components = null;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//                components.Dispose();
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        private void InitializeComponent()
//        {
//            this.dgvData = new System.Windows.Forms.DataGridView();
//            this.btnAdd = new System.Windows.Forms.Button();
//            this.btnExportExcel = new System.Windows.Forms.Button();
//            this.btnEdit = new System.Windows.Forms.Button();
//            this.btnDelete = new System.Windows.Forms.Button();
//            this.btnLoadData = new System.Windows.Forms.Button();
//            this.btnExportPDF = new System.Windows.Forms.Button();
//            this.txtSearch = new System.Windows.Forms.TextBox();
//            this.btnSearch = new System.Windows.Forms.Button();
//            this.lblStatus = new System.Windows.Forms.Label();
//            this.labelTitle = new System.Windows.Forms.Label();  // renamed from label2 to avoid confusion
//            this.panelTop = new System.Windows.Forms.Panel();
//            this.panelGrid = new System.Windows.Forms.Panel();
//            this.panelBottom = new System.Windows.Forms.Panel();

//            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
//            this.panelTop.SuspendLayout();
//            this.panelGrid.SuspendLayout();
//            this.panelBottom.SuspendLayout();
//            this.SuspendLayout();

//            // ================= DATA GRID VIEW =================
//            this.dgvData.AllowUserToAddRows = false;
//            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.dgvData.ReadOnly = true;
//            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);

//            // ================= TOP PANEL =================
//            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
//            this.panelTop.Height = 150;
//            this.panelTop.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);  // nicer color

//            // Title
//            this.labelTitle.Text = "DataPilot Dashboard";
//            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
//            this.labelTitle.ForeColor = System.Drawing.Color.White;
//            this.labelTitle.AutoSize = true;
//            this.labelTitle.Location = new System.Drawing.Point(400, 10);

//            // Buttons
//            this.btnAdd.Text = "Add";
//            this.btnAdd.Location = new System.Drawing.Point(800, 80);
//            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

//            this.btnEdit.Text = "Edit";
//            this.btnEdit.Location = new System.Drawing.Point(350, 80);
//            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

//            this.btnDelete.Text = "Delete";
//            this.btnDelete.Location = new System.Drawing.Point(550, 80);
//            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

//            // Search
//            this.txtSearch.Location = new System.Drawing.Point(300, 120);
//            this.txtSearch.Width = 200;
//            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

//            this.btnSearch.Text = "Search";
//            this.btnSearch.Location = new System.Drawing.Point(520, 120);
//            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

//            // Add controls to top panel
//            this.panelTop.Controls.Add(this.labelTitle);
//            this.panelTop.Controls.Add(this.btnAdd);
//            this.panelTop.Controls.Add(this.btnEdit);
//            this.panelTop.Controls.Add(this.btnDelete);
//            this.panelTop.Controls.Add(this.txtSearch);
//            this.panelTop.Controls.Add(this.btnSearch);

//            // ================= GRID PANEL =================
//            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.panelGrid.Controls.Add(this.dgvData);

//            // ================= BOTTOM PANEL =================
//            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
//            this.panelBottom.Height = 100;
//            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);

//            this.btnExportExcel.Text = "Export Excel";
//            this.btnExportExcel.Location = new System.Drawing.Point(350, 30);
//            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);

//            this.btnExportPDF.Text = "Export PDF";
//            this.btnExportPDF.Location = new System.Drawing.Point(500, 30);
//            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);

//            this.btnLoadData.Text = "Load Data";
//            this.btnLoadData.Location = new System.Drawing.Point(650, 30);
//            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);

//            this.lblStatus.Text = "Ready";
//            this.lblStatus.ForeColor = System.Drawing.Color.White;
//            this.lblStatus.AutoSize = true;
//            this.lblStatus.Location = new System.Drawing.Point(850, 35);
//            // No click event for status label – removed to avoid error

//            this.panelBottom.Controls.Add(this.btnExportExcel);
//            this.panelBottom.Controls.Add(this.btnExportPDF);
//            this.panelBottom.Controls.Add(this.btnLoadData);
//            this.panelBottom.Controls.Add(this.lblStatus);

//            // ================= FORM =================
//            this.ClientSize = new System.Drawing.Size(1370, 749);
//            this.Controls.Add(this.panelGrid);
//            this.Controls.Add(this.panelBottom);
//            this.Controls.Add(this.panelTop);
//            this.Text = "DataPilot Dashboard";
//            this.Load += new System.EventHandler(this.DashboardForm_Load);

//            // Clean up
//            this.panelTop.ResumeLayout(false);
//            this.panelTop.PerformLayout();
//            this.panelGrid.ResumeLayout(false);
//            this.panelBottom.ResumeLayout(false);
//            this.panelBottom.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
//            this.ResumeLayout(false);
//        }

//        #endregion

//        // Control declarations
//        private System.Windows.Forms.DataGridView dgvData;
//        private System.Windows.Forms.Button btnAdd;
//        private System.Windows.Forms.Button btnExportExcel;
//        private System.Windows.Forms.Button btnEdit;
//        private System.Windows.Forms.Button btnDelete;
//        private System.Windows.Forms.Button btnLoadData;
//        private System.Windows.Forms.Button btnExportPDF;
//        private System.Windows.Forms.TextBox txtSearch;
//        private System.Windows.Forms.Button btnSearch;
//        private System.Windows.Forms.Label lblStatus;
//        private System.Windows.Forms.Label labelTitle;
//        private System.Windows.Forms.Panel panelTop;
//        private System.Windows.Forms.Panel panelGrid;
//        private System.Windows.Forms.Panel panelBottom;
//    }
//}




namespace DataPilot
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panelGrid.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(1370, 465);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dgvData);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 150);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1370, 465);
            this.panelGrid.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelBottom.BackgroundImage = global::DataPilot.Properties.Resources.Gemini_Generated_Image_d4er1rd4er1rd4er2;
            this.panelBottom.Controls.Add(this.btnExportExcel);
            this.panelBottom.Controls.Add(this.btnExportPDF);
            this.panelBottom.Controls.Add(this.btnLoadData);
            this.panelBottom.Controls.Add(this.lblStatus);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 615);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1370, 134);
            this.panelBottom.TabIndex = 1;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportExcel.Location = new System.Drawing.Point(367, 36);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(149, 23);
            this.btnExportExcel.TabIndex = 0;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.BackColor = System.Drawing.Color.Red;
            this.btnExportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportPDF.Location = new System.Drawing.Point(597, 36);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(149, 23);
            this.btnExportPDF.TabIndex = 1;
            this.btnExportPDF.Text = "Export PDF";
            this.btnExportPDF.UseVisualStyleBackColor = false;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoadData.Location = new System.Drawing.Point(805, 36);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(149, 23);
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(347, 77);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 25);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Ready";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelTop.BackgroundImage = global::DataPilot.Properties.Resources.Gemini_Generated_Image_d4er1rd4er1rd4er1;
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.btnEdit);
            this.panelTop.Controls.Add(this.btnDelete);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1370, 150);
            this.panelTop.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Transparent;
            this.labelTitle.Location = new System.Drawing.Point(472, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(333, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "DataPilot Dashboard";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(805, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(376, 80);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(149, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(597, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(367, 118);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(564, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(149, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "DashboardForm";
            this.Text = "DataPilot Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panelGrid.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // Control declarations
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panelBottom;
    }
}
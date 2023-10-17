namespace _3_PRL.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTen = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtIDPH = new TextBox();
            txtSearch = new TextBox();
            btnShow = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            cmbType = new ComboBox();
            dtgView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 52);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Ten";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 91);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Dia Chi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 133);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 176);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 3;
            label4.Text = "SDT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 213);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 4;
            label5.Text = "ID Phu Huynh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 271);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 5;
            label6.Text = "Search";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(156, 52);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(346, 23);
            txtTen.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(156, 88);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(346, 23);
            txtDiaChi.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(156, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(346, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(156, 173);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(346, 23);
            txtSDT.TabIndex = 9;
            // 
            // txtIDPH
            // 
            txtIDPH.Location = new Point(156, 210);
            txtIDPH.Name = "txtIDPH";
            txtIDPH.Size = new Size(346, 23);
            txtIDPH.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(156, 268);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(346, 23);
            txtSearch.TabIndex = 11;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(546, 52);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(232, 40);
            btnShow.TabIndex = 12;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(546, 98);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(232, 40);
            btnThem.TabIndex = 13;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(546, 144);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(232, 40);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(546, 190);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(232, 40);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(546, 268);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(232, 23);
            cmbType.TabIndex = 16;
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(35, 310);
            dtgView.Name = "dtgView";
            dtgView.RowTemplate.Height = 25;
            dtgView.Size = new Size(743, 193);
            dtgView.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 515);
            Controls.Add(dtgView);
            Controls.Add(cmbType);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnShow);
            Controls.Add(txtSearch);
            Controls.Add(txtIDPH);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTen);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTen;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtIDPH;
        private TextBox txtSearch;
        private Button btnShow;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private ComboBox cmbType;
        private DataGridView dtgView;
    }
}
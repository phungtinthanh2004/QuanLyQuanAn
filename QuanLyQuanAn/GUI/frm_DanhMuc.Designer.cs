namespace GUI
{
    partial class frm_DanhMuc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_UploadImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenDanhMuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.opf_HinhAnhDanhMuc = new System.Windows.Forms.OpenFileDialog();
            this.pib_HinhAnhDanhMuc = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rad_An = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rad_Hien = new System.Windows.Forms.RadioButton();
            this.btn_ThemMoi = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SearchKey = new System.Windows.Forms.TextBox();
            this.dgv_DanhMuc = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_HinhAnhDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.rad_Hien);
            this.panel1.Controls.Add(this.btn_CapNhat);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.btn_ThemMoi);
            this.panel1.Controls.Add(this.rad_An);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_UploadImage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_TenDanhMuc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 200);
            this.panel1.TabIndex = 0;
            // 
            // btn_UploadImage
            // 
            this.btn_UploadImage.Location = new System.Drawing.Point(106, 64);
            this.btn_UploadImage.Name = "btn_UploadImage";
            this.btn_UploadImage.Size = new System.Drawing.Size(119, 39);
            this.btn_UploadImage.TabIndex = 3;
            this.btn_UploadImage.Text = "Tải hình ảnh";
            this.btn_UploadImage.UseVisualStyleBackColor = true;
            this.btn_UploadImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hình ảnh";
            // 
            // txt_TenDanhMuc
            // 
            this.txt_TenDanhMuc.Location = new System.Drawing.Point(106, 17);
            this.txt_TenDanhMuc.Multiline = true;
            this.txt_TenDanhMuc.Name = "txt_TenDanhMuc";
            this.txt_TenDanhMuc.Size = new System.Drawing.Size(245, 33);
            this.txt_TenDanhMuc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên danh mục";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_SearchKey);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(383, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 50);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_DanhMuc);
            this.panel3.Location = new System.Drawing.Point(383, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 376);
            this.panel3.TabIndex = 2;
            // 
            // opf_HinhAnhDanhMuc
            // 
            this.opf_HinhAnhDanhMuc.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pib_HinhAnhDanhMuc
            // 
            this.pib_HinhAnhDanhMuc.Location = new System.Drawing.Point(12, 218);
            this.pib_HinhAnhDanhMuc.Name = "pib_HinhAnhDanhMuc";
            this.pib_HinhAnhDanhMuc.Size = new System.Drawing.Size(184, 226);
            this.pib_HinhAnhDanhMuc.TabIndex = 3;
            this.pib_HinhAnhDanhMuc.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trạng thái";
            // 
            // rad_An
            // 
            this.rad_An.AutoSize = true;
            this.rad_An.Location = new System.Drawing.Point(107, 118);
            this.rad_An.Name = "rad_An";
            this.rad_An.Size = new System.Drawing.Size(47, 20);
            this.rad_An.TabIndex = 5;
            this.rad_An.TabStop = true;
            this.rad_An.Text = "Ẩn ";
            this.rad_An.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(-391, -193);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 20);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hiện";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rad_Hien
            // 
            this.rad_Hien.AutoSize = true;
            this.rad_Hien.Location = new System.Drawing.Point(179, 116);
            this.rad_Hien.Name = "rad_Hien";
            this.rad_Hien.Size = new System.Drawing.Size(56, 20);
            this.rad_Hien.TabIndex = 7;
            this.rad_Hien.TabStop = true;
            this.rad_Hien.Text = "Hiện";
            this.rad_Hien.UseVisualStyleBackColor = true;
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.Location = new System.Drawing.Point(13, 148);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(112, 35);
            this.btn_ThemMoi.TabIndex = 4;
            this.btn_ThemMoi.Text = "Thêm mới";
            this.btn_ThemMoi.UseVisualStyleBackColor = true;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(131, 148);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(112, 35);
            this.btn_CapNhat.TabIndex = 5;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(249, 148);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(102, 35);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tìm kiếm";
            // 
            // txt_SearchKey
            // 
            this.txt_SearchKey.Location = new System.Drawing.Point(83, 5);
            this.txt_SearchKey.Multiline = true;
            this.txt_SearchKey.Name = "txt_SearchKey";
            this.txt_SearchKey.Size = new System.Drawing.Size(451, 36);
            this.txt_SearchKey.TabIndex = 9;
            // 
            // dgv_DanhMuc
            // 
            this.dgv_DanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhMuc.Location = new System.Drawing.Point(0, 0);
            this.dgv_DanhMuc.Name = "dgv_DanhMuc";
            this.dgv_DanhMuc.RowHeadersWidth = 51;
            this.dgv_DanhMuc.RowTemplate.Height = 24;
            this.dgv_DanhMuc.Size = new System.Drawing.Size(553, 376);
            this.dgv_DanhMuc.TabIndex = 0;
            // 
            // frm_DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 473);
            this.Controls.Add(this.pib_HinhAnhDanhMuc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_DanhMuc";
            this.Text = "Quản Lý Danh Mục";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pib_HinhAnhDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_TenDanhMuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog opf_HinhAnhDanhMuc;
        private System.Windows.Forms.Button btn_UploadImage;
        private System.Windows.Forms.PictureBox pib_HinhAnhDanhMuc;
        private System.Windows.Forms.RadioButton rad_Hien;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rad_An;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ThemMoi;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_SearchKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_DanhMuc;
    }
}
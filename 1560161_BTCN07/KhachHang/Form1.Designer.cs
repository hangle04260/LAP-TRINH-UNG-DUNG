namespace KhachHang
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
            this.grKhachHang = new System.Windows.Forms.GroupBox();
            this.comboquan = new System.Windows.Forms.ComboBox();
            this.combothanhpho = new System.Windows.Forms.ComboBox();
            this.datngaysinh = new System.Windows.Forms.DateTimePicker();
            this.texmakh = new System.Windows.Forms.TextBox();
            this.texhoten = new System.Windows.Forms.TextBox();
            this.checkNu = new System.Windows.Forms.CheckBox();
            this.checkNam = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttAnhDaiDien = new System.Windows.Forms.Button();
            this.jpgAnh = new System.Windows.Forms.PictureBox();
            this.butThemKhachHang = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DgrDanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.grKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jpgAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgrDanhSachKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // grKhachHang
            // 
            this.grKhachHang.Controls.Add(this.comboquan);
            this.grKhachHang.Controls.Add(this.combothanhpho);
            this.grKhachHang.Controls.Add(this.datngaysinh);
            this.grKhachHang.Controls.Add(this.texmakh);
            this.grKhachHang.Controls.Add(this.texhoten);
            this.grKhachHang.Controls.Add(this.checkNu);
            this.grKhachHang.Controls.Add(this.checkNam);
            this.grKhachHang.Controls.Add(this.label6);
            this.grKhachHang.Controls.Add(this.label5);
            this.grKhachHang.Controls.Add(this.label4);
            this.grKhachHang.Controls.Add(this.label3);
            this.grKhachHang.Controls.Add(this.label2);
            this.grKhachHang.Controls.Add(this.label1);
            this.grKhachHang.Controls.Add(this.buttAnhDaiDien);
            this.grKhachHang.Controls.Add(this.jpgAnh);
            this.grKhachHang.Location = new System.Drawing.Point(42, 22);
            this.grKhachHang.Name = "grKhachHang";
            this.grKhachHang.Size = new System.Drawing.Size(658, 299);
            this.grKhachHang.TabIndex = 0;
            this.grKhachHang.TabStop = false;
            this.grKhachHang.Text = "Khách hàng";
            // 
            // comboquan
            // 
            this.comboquan.FormattingEnabled = true;
            this.comboquan.Location = new System.Drawing.Point(398, 209);
            this.comboquan.Name = "comboquan";
            this.comboquan.Size = new System.Drawing.Size(244, 21);
            this.comboquan.TabIndex = 6;
            // 
            // combothanhpho
            // 
            this.combothanhpho.FormattingEnabled = true;
            this.combothanhpho.Location = new System.Drawing.Point(398, 162);
            this.combothanhpho.Name = "combothanhpho";
            this.combothanhpho.Size = new System.Drawing.Size(244, 21);
            this.combothanhpho.TabIndex = 6;
            this.combothanhpho.SelectedIndexChanged += new System.EventHandler(this.combothanhpho_SelectedIndexChanged);
            // 
            // datngaysinh
            // 
            this.datngaysinh.Location = new System.Drawing.Point(398, 116);
            this.datngaysinh.Name = "datngaysinh";
            this.datngaysinh.Size = new System.Drawing.Size(244, 20);
            this.datngaysinh.TabIndex = 5;
            this.datngaysinh.Value = new System.DateTime(2017, 10, 22, 16, 11, 11, 0);
            // 
            // texmakh
            // 
            this.texmakh.Location = new System.Drawing.Point(398, 21);
            this.texmakh.Name = "texmakh";
            this.texmakh.Size = new System.Drawing.Size(244, 20);
            this.texmakh.TabIndex = 4;
            // 
            // texhoten
            // 
            this.texhoten.Location = new System.Drawing.Point(398, 68);
            this.texhoten.Name = "texhoten";
            this.texhoten.Size = new System.Drawing.Size(244, 20);
            this.texhoten.TabIndex = 4;
            // 
            // checkNu
            // 
            this.checkNu.AutoSize = true;
            this.checkNu.Location = new System.Drawing.Point(543, 262);
            this.checkNu.Name = "checkNu";
            this.checkNu.Size = new System.Drawing.Size(40, 17);
            this.checkNu.TabIndex = 3;
            this.checkNu.Text = "Nữ";
            this.checkNu.UseVisualStyleBackColor = true;
            // 
            // checkNam
            // 
            this.checkNam.AutoSize = true;
            this.checkNam.Location = new System.Drawing.Point(398, 262);
            this.checkNam.Name = "checkNam";
            this.checkNam.Size = new System.Drawing.Size(48, 17);
            this.checkNam.TabIndex = 3;
            this.checkNam.Text = "Nam";
            this.checkNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(227, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(227, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quận ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(227, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thành phố";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(227, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(227, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(227, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khách hàng";
            // 
            // buttAnhDaiDien
            // 
            this.buttAnhDaiDien.Location = new System.Drawing.Point(28, 157);
            this.buttAnhDaiDien.Name = "buttAnhDaiDien";
            this.buttAnhDaiDien.Size = new System.Drawing.Size(135, 23);
            this.buttAnhDaiDien.TabIndex = 1;
            this.buttAnhDaiDien.Text = "Chọn Ảnh Đại Diện";
            this.buttAnhDaiDien.UseVisualStyleBackColor = true;
            this.buttAnhDaiDien.Click += new System.EventHandler(this.buttAnhDaiDien_Click);
            // 
            // jpgAnh
            // 
            this.jpgAnh.Location = new System.Drawing.Point(15, 19);
            this.jpgAnh.Name = "jpgAnh";
            this.jpgAnh.Size = new System.Drawing.Size(161, 118);
            this.jpgAnh.TabIndex = 0;
            this.jpgAnh.TabStop = false;
            // 
            // butThemKhachHang
            // 
            this.butThemKhachHang.Location = new System.Drawing.Point(273, 3);
            this.butThemKhachHang.Name = "butThemKhachHang";
            this.butThemKhachHang.Size = new System.Drawing.Size(133, 23);
            this.butThemKhachHang.TabIndex = 2;
            this.butThemKhachHang.Text = "Thêm";
            this.butThemKhachHang.UseVisualStyleBackColor = true;
            this.butThemKhachHang.Click += new System.EventHandler(this.butThemKhachHang_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DgrDanhSachKhachHang
            // 
            this.DgrDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgrDanhSachKhachHang.Location = new System.Drawing.Point(42, 327);
            this.DgrDanhSachKhachHang.MultiSelect = false;
            this.DgrDanhSachKhachHang.Name = "DgrDanhSachKhachHang";
            this.DgrDanhSachKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgrDanhSachKhachHang.Size = new System.Drawing.Size(658, 322);
            this.DgrDanhSachKhachHang.TabIndex = 3;
            this.DgrDanhSachKhachHang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgrDanhSachKhachHang_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 661);
            this.Controls.Add(this.DgrDanhSachKhachHang);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butThemKhachHang);
            this.Controls.Add(this.grKhachHang);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grKhachHang.ResumeLayout(false);
            this.grKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jpgAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgrDanhSachKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grKhachHang;
        private System.Windows.Forms.PictureBox jpgAnh;
        private System.Windows.Forms.Button buttAnhDaiDien;
        private System.Windows.Forms.DateTimePicker datngaysinh;
        private System.Windows.Forms.TextBox texmakh;
        private System.Windows.Forms.TextBox texhoten;
        private System.Windows.Forms.CheckBox checkNu;
        private System.Windows.Forms.CheckBox checkNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combothanhpho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboquan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butThemKhachHang;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView DgrDanhSachKhachHang;
    }
}


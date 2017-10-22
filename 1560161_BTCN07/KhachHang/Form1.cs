using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private BindingList<KhachHang> lstDanhSach = new BindingList<KhachHang>();

        

        private void buttAnhDaiDien_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Title = "Khách Hàng";
            image.InitialDirectory = @"C:\Users\thien\";
            image.Filter = "Image|*.jpg;*.jpeg;*.png;*.bmp|All file type|*.*";
            if (image.ShowDialog() == DialogResult.OK)
            {
                jpgAnh.Image = Image.FromFile(image.FileName); 

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combothanhpho.Items.Add("TP HCM");
            combothanhpho.Items.Add("Hà Nội");
            combothanhpho.Items.Add("Đà Nẵng");

        }

        private void butThemKhachHang_Click(object sender, EventArgs e)
        {
            string makh = texmakh.Text;
            string hoten = texhoten.Text;
            string ngaysinh = datngaysinh.Text;
            string gioitinh = null;
            if(checkNam.Checked)
            {
                gioitinh = "Nam";

            }
            else
            {
                gioitinh = "Nữ";
            }
            string thanhpho = combothanhpho.Text;
            string quan = comboquan.Text;
            KhachHang a = new KhachHang();
            a.makh = makh;
            a.hoten = hoten;
            a.ngaysinh = ngaysinh;
            a.thanhpho = thanhpho;
            a.quan = quan;
            a.gioitinh = gioitinh;
            lstDanhSach.Add(a);
            DgrDanhSachKhachHang.DataSource = lstDanhSach;
            texmakh.Text = "";
            texhoten.Text = "";
            datngaysinh.Text = "";
            combothanhpho.Text = "";
            comboquan.Text = "";
            if (checkNu.Checked)
                checkNu.Checked = false;
            else
                checkNam.Checked = false;
        }

        private void combothanhpho_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> lstQuanHN = new List<string>();
            lstQuanHN.AddRange(new string[] { "Hoàn	Kiếm", "Ba	Đình", "Đống	Đa", "Tây	Hồ", "Cầu	Giấy" });

            List<string> lstQuanDN = new List<string>(new string[] { "Hải Châu", "Sơn	Trà", "Ngũ	Hành	Sơn" });

            List<string> lstQuanSG = new List<string>();
            lstQuanSG.Add("Quận	1");
            lstQuanSG.Add("Phú	Nhuận");
            lstQuanSG.Add("Bình	Thạnh");
            lstQuanSG.Add("Gò	Vấp");

            object[] lstQuan = null;
            switch (combothanhpho.SelectedIndex)
            {
                case 0:
                    lstQuan = lstQuanSG.ToArray();
                    break;

                case 1:
                    lstQuan = lstQuanHN.ToArray();
                    break;

                default:
                    lstQuan = lstQuanDN.ToArray();
                    break;
            };

            comboquan.Items.Clear();
            comboquan.Items.AddRange(lstQuan);
        }

        private void DgrDanhSachKhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            
                texmakh.Text = DgrDanhSachKhachHang.CurrentRow.Cells[0].Value.ToString();
                texhoten.Text = DgrDanhSachKhachHang.CurrentRow.Cells[1].Value.ToString();
                datngaysinh.Text= DgrDanhSachKhachHang.CurrentRow.Cells[2].Value.ToString();
                combothanhpho.Text = DgrDanhSachKhachHang.CurrentRow.Cells[3].Value.ToString();
                comboquan.Text = DgrDanhSachKhachHang.CurrentRow.Cells[4].Value.ToString();
            if(checkNu.Checked)
                checkNu.Text= DgrDanhSachKhachHang.CurrentRow.Cells[5].Value.ToString();
            else
                checkNu.Text = DgrDanhSachKhachHang.CurrentRow.Cells[5].Value.ToString(); 




        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            DgrDanhSachKhachHang.Rows.Remove(DgrDanhSachKhachHang.SelectedRows[0]);
            texmakh.Text = "";
            texhoten.Text = "";
            datngaysinh.Text = "";
            combothanhpho.Text = "";
            comboquan.Text = "";
            if (checkNu.Checked)
                checkNu.Checked = false;
            else
                checkNam.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DgrDanhSachKhachHang.CurrentRow.Cells[0].Value =texmakh.Text;
            DgrDanhSachKhachHang.CurrentRow.Cells[1].Value= texhoten.Text ;
            DgrDanhSachKhachHang.CurrentRow.Cells[2].Value = datngaysinh.Text ;
            DgrDanhSachKhachHang.CurrentRow.Cells[3].Value= combothanhpho.Text ;
            DgrDanhSachKhachHang.CurrentRow.Cells[4].Value= comboquan.Text ;
            if (checkNu.Checked)
               DgrDanhSachKhachHang.CurrentRow.Cells[5].Value = checkNu.Text ;
            else
                DgrDanhSachKhachHang.CurrentRow.Cells[5].Value= checkNu.Text ;

        }
    }
}

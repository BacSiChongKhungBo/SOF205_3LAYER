using BUS.Services;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PRL.Forms
{
    public partial class Form1 : Form
    {
        //khai bao service
        private SinhVienService _service;
        public Form1()
        {
            InitializeComponent();
            //khoi tao
            _service = new SinhVienService();
            LoadComboBox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var sv = new Sinhvien();
            //gan gia tri tu txtbox vao sv
            sv.Ten = txtTen.Text;
            sv.Email = txtEmail.Text;
            sv.Diachi = txtDiaChi.Text;
            sv.Sdt = txtSDT.Text;
            sv.IdPh = int.Parse(txtIDPH.Text);
            MessageBox.Show(_service.Add(sv));
        }

        private void LoadComboBox()
        {
            //add du lieu vao combo
            cmbType.Items.Add("All");
            cmbType.Items.Add("find by Name");
            cmbType.Items.Add("find by Mail");
            cmbType.Items.Add("find by SDT");
            //hien thi cai gi dau tien
            cmbType.SelectedIndex = 0;
            //khoa edit combo
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //stt
            int stt = 1;
            // xac dinh, dtg se co bnh cot
            dtgView.ColumnCount = 8;
            //dat ten cot
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "ID";
            dtgView.Columns[2].Name = "Ten";
            dtgView.Columns[3].Name = "Email";
            dtgView.Columns[4].Name = "DiaChi";
            dtgView.Columns[5].Name = "SDT";
            dtgView.Columns[6].Name = "TenPH";
            dtgView.Columns[7].Name = "Nghe Nghiep";
            //giau ID
            dtgView.Columns[1].Visible = false;
            //xoa dong moi lan cap nhat
            dtgView.Rows.Clear();
            //them dong dua tren cac dieu kien
            foreach (var x in _service.GetSV(txtSearch.Text, cmbType.SelectedIndex))
            {
                int idPH = (int)x.IdPh;
                if (_service.GetPH(idPH) != null)
                {
                    var ph = _service.GetPH(idPH);
                    dtgView.Rows.Add(stt++, x.Id, x.Ten, x.Email, x.Diachi, x.Sdt, ph.Ten, ph.Nghenghiep);
                }
                else
                {
                    dtgView.Rows.Add(stt++, x.Id, x.Ten, x.Email, x.Diachi, x.Sdt);
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}

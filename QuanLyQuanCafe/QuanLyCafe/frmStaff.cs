using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.KetNoiDichVuStaff;
namespace QuanLyCafe
{
    public partial class frmStaff : Form
    {

        private int fluu = 1;
        public frmStaff()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            DataSet ds = staff.GetStaff();
            dgvNhanVien.DataSource = ds.Tables[0];
        }
        ServiceStaffClient staff = new ServiceStaffClient();
        Staff nv = new Staff();
        private void frmStaff_Load(object sender, EventArgs e)
        {
            txtHoTen.Enabled = false;
            txtMaNV.Enabled = false;
            cmbGioiTinh.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            dateNgaySinh.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void brnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtHoTen.Enabled = true;
            txtMaNV.Enabled = true;
            cmbGioiTinh.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            dateNgaySinh.Enabled = true;
        }

        private void btnLuuu_Click(object sender, EventArgs e)
        {
            nv.name = txtHoTen.Text;
            nv.id = Convert.ToInt32(txtMaNV.Text);
            nv.birthday = Convert.ToDateTime(dateNgaySinh.Text);
            nv.sex = cmbGioiTinh.Text;
            nv.phone = txtSDT.Text;
            nv.address = txtDiaChi.Text;

            if (fluu == 0)
            {
                staff.AddStaff(nv);
                MessageBox.Show("Thêm thành công!");
                HienThi();
            }
            else
            {
                staff.UpdateStaff(nv);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            txtHoTen.Enabled = true;
            txtMaNV.Enabled = true;
            cmbGioiTinh.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            dateNgaySinh.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = true;
            txtMaNV.Enabled = true;
            cmbGioiTinh.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            dateNgaySinh.Enabled = true;
            nv.id = Convert.ToInt32(txtMaNV.Text);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                staff.DeleteStaff(nv);
                MessageBox.Show("Xóa thành công!");
                HienThi();
            }
        }

        private void btnThoatt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

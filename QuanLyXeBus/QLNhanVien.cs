using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeBus
{
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
            LoadNhanVien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemNhanVien form = new ThemNhanVien();
            form.ShowDialog();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {

        }
        public void LoadNhanVien()
        {
            string query = "select TenTK as [Tài Khoản], MaTK as [Mã số], MatKhau as [Mật Khẩu],HoTen as [Họ Tên], " +
                "LienLac as [Liên Lạc],ChucVu as [Chức Vụ],NgaySinh as [Ngày Sinh] from NhanVien";
            string connectionString = "Data Source=LAPTOP-N9ELN8MN\\SQLEXPRESS01;Initial Catalog=BusManager;Integrated Security=True";
            DataProvider.Instance.SetConnectionString(connectionString);
            dataGridView1.DataSource =  DataProvider.Instance.DataTableByQuery(query);
        }
    }
}

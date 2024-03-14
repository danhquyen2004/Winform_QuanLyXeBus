using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            string connectionString = "Data Source=.;Initial Catalog=BusManager;Integrated Security=True;Encrypt=False";
            DataProvider.Instance.SetConnectionString(connectionString);
            dataGridView1.DataSource =  DataProvider.Instance.DataTableByQuery(query);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            string masoxoa = Convert.ToString(dataGridView1.Rows[selectedIndex].Cells[1].Value);
            string query = "Delete from NhanVien where MaTK = "+masoxoa;
            string connectionString = "Data Source=.;Initial Catalog=BusManager;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandText = query;
            int check = command.ExecuteNonQuery();
            connection.Close();
            if (check > 0)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedIndex];


            ThemNhanVien form = new ThemNhanVien(row);
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

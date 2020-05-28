using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyThuVien
{
    public partial class F_CapNhatBanDoc : Form
    {
        public F_CapNhatBanDoc()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        MySqlDataAdapter adapter;
        DataSet ds = new DataSet();
        private void F_CapNhatBanDoc_Load(object sender, EventArgs e)
        {
            ClassConnect clsCon = new ClassConnect();
            con = clsCon.getconnect();
            con.Open();
            string strSql = "select * from bandoc";
            adapter = new MySqlDataAdapter(strSql, con);
            adapter.Fill(ds, "bd");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "bd";
            con.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(
                "insert into bandoc(mabandoc,tenbandoc,ngaysinh,gioitinh,doituong,diachi) " + 
                "values(@mabandoc,@tenbandoc,@ngaysinh,@gioitinh,@doituong,@diachi)", con);
            cmd.Parameters.Add("@mabandoc", MySqlDbType.VarChar).Value = txtMabandoc.Text;
            cmd.Parameters.Add("@tenbandoc", MySqlDbType.VarChar).Value = txtTenbandoc.Text;
            cmd.Parameters.Add("@ngaysinh", MySqlDbType.Date).Value = dtpNgaysinh.Value;
            cmd.Parameters.Add("@gioitinh", MySqlDbType.VarChar).Value = txtGioitinh.Text;
            cmd.Parameters.Add("@doituong", MySqlDbType.VarChar).Value = txtDoithuong.Text;
            cmd.Parameters.Add("@diachi", MySqlDbType.VarChar).Value = txtDiachi.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm mới thành công.");
            LoadData();
            con.Close();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataSet changes = new DataSet();
            MySqlCommandBuilder builder = new   MySqlCommandBuilder(adapter);
            changes = ds.GetChanges();
            if (changes == null) MessageBox.Show("Chưa có bất kỳ thay đổi nào");
            else
            {
                adapter.Update(ds.Tables["bd"]);
                ds.AcceptChanges();
                MessageBox.Show("Cập nhật thành công");
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmddelete;
            string strdelete = "delete from bandoc where mabandoc='" + txtMabandoc.Text + "'";
            cmddelete = new MySqlCommand(strdelete, con);
            cmddelete.ExecuteNonQuery();
            MessageBox.Show("Lệnh xóa đã được thực hiện.");
            LoadData();
            con.Close();

        }
        void LoadData()
        {
            while (dataGridView1.RowCount - 1 > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            string strSql = "SELECT * FROM bandoc";
            adapter  = new MySqlDataAdapter(strSql, con);
            adapter.Fill(ds, "bd");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "bd";
            con.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

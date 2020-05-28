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
    public partial class F_TheLoaiSach : Form
    {
        public F_TheLoaiSach()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection();
        MySqlDataAdapter da1, da2;
        BindingSource bds1, bds2;
        DataSet ds = new DataSet();

        private void F_TheLoaiSach_Load(object sender, EventArgs e)
        {
            DataTable dt1, dt2;
            DataRelation relation;
            ClassConnect clsCon = new ClassConnect();
            con = clsCon.getconnect();
            con.Open();
            //Lấy và xử lý dữ liệu khách hàng
            MySqlCommand cmd = new MySqlCommand();
            string strSql1 = "SELECT * FROM loaisach";
            da1 = new MySqlDataAdapter(strSql1, con);
            string strSql2 = "SELECT a.masach,a.tensach,a.nganke,a.dongia,b.ngaymuon,b.ngaytra,a.id_loaisach, " +
                "(b.ngaytra-b.ngaymuon)*a.dongia as thanhtien FROM sach a,muonsach b where a.id_sach=b.id_sach;";
            da2 = new MySqlDataAdapter(strSql2, con);
            //Tạo Dataset chứa toàn bộ dữ liệu
            da1.Fill(ds, "Master");
            da2.Fill(ds, "Detail");
            //Tạo mối quan hệ giữa 2 Table bằng DataRelation
            dt1 = ds.Tables["Master"];
            dt2 = ds.Tables["Detail"];
            relation = new DataRelation("relation12",
                dt1.Columns["id_loaisach"], dt2.Columns["id_loaisach"]);
            ds.Relations.Add(relation);
            //Thiết lập quan hệ thực sự giữa 2 Table
            bds1 = new BindingSource();
            bds1.DataSource = ds;
            bds1.DataMember = "Master";
            bds2 = new BindingSource();
            bds2.DataSource = bds1;
            bds2.DataMember = "relation12";
            //Đặt nguồn dữ liệu hiển thị cho các Control
            dataGridView1.DataSource = bds2;
            cboMaloai.DataSource = bds1;
            cboMaloai.ValueMember = "maloaisach";
            //Sử dụng thuộc tính DataBindings
            txtTenloai.DataBindings.Add(new Binding(
                "Text", bds1, "tenloai", true));
            txtTengia.DataBindings.Add(new Binding(
                "Text", bds1, "tengia", true));
            
            con.Close();

        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            float tt = 0; int i;
            for (i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                tt = tt + Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value);
            }

           txtThanhtien.Text = String.Format("{0:0.0}", tt);


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyThuVien
{
    class ClassConnect
    {
        public MySqlConnection getconnect()
        {
            MySqlConnection cn = new MySqlConnection();
            string str = "Server =localhost;" +
                         "Database =quanlythuvien;" +
                         "Port =3306;" +
                         "User ID =root;" +
                         "Password =;" +
                         "charset = utf8; old guids =true;" +
                         "pooling =false; convert zero datetime= true";
            cn.ConnectionString = str;
            return cn;
        }

    }
}

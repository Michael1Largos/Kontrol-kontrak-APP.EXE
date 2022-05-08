using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kontrak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string alamat = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\MIchael Limas\Documents\Kontrol Kontrak\Kontrak\Database1.mdf"";Integrated Security=True";
            SqlConnection con = new SqlConnection(alamat);
            var sql = "INSERT INTO Data VALUES(@nomor, @nama)";
            con.Open();
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@nomor", nomor.Text);
                cmd.Parameters.AddWithValue("@nama", nama.Text);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void show_Click(object sender, EventArgs e)
        {
            string alamat = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\MIchael Limas\Documents\Kontrol Kontrak\Kontrak\Database1.mdf"";Integrated Security=True";
            SqlConnection con = new SqlConnection(alamat);
            SqlCommand Comm1 = new SqlCommand(Command, Con);
        }
    }
}

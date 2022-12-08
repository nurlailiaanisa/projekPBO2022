using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projek
{
    public partial class Penyewa : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void selectDataKos(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["postgresdb"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Select * from data_kos";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();
                    connection.Close();

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }

        protected void selectDataPemilik(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["postgresdb"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Select * from pemilik_kos";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();
                    connection.Close();

                    GridView2.DataSource = dt;
                    GridView2.DataBind();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }

        protected void ajukan_sewa(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["postgresdb"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Insert into penyewaan(tanggal, nama_penyewa, no_hp, kos) values (@tanggal, @nama_penyewa, @no_hp, @kos)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@tanggal", TanggalSewa.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@nama_penyewa", NamaPenyewa.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@no_hp", NoHp.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@kos", Convert.ToInt32(IDKos.Text)));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    TanggalSewa.Text = "";
                    NamaPenyewa.Text = "";
                    NoHp.Text = "";
                    IDKos.Text = "";
                    lblmsgSewa.Text = "Success";
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }

    }
}
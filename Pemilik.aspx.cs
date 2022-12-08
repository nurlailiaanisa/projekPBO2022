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
using System.Xml.Linq;

namespace projek
{
    public partial class _Pemilik : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tambahDataPemilik(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["postgresdb"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Insert into pemilik_kos(id_pemilik,nama_pemilik,no_hp,email) values (@id_pemilik,@nama_pemilik,@no_hp,@email)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@id_pemilik", idPemilik.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@nama_pemilik", NamaPemilik.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@no_hp", NoHp.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@email", Email.Text));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    idPemilik.Text = "";
                    NamaPemilik.Text = "";
                    NoHp.Text = "";
                    Email.Text = "";
                    lblmsgPemilik.Text = "Data Has been Saved";
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }

        protected void ubahDataPemilik(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["postgresdb"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Update pemilik_kos set nama_pemilik=@nama_pemilik, no_hp=@no_hp, email=@email where id_pemilik=@id_pemilik";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@id_pemilik", idPemilik.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@nama_pemilik", NamaPemilik.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@no_hp", NoHp.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@email", Email.Text));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    idPemilik.Text = "";
                    NamaPemilik.Text = "";
                    NoHp.Text = "";
                    Email.Text = "";
                    lblmsgPemilik.Text = "Data Has been Updated";
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }

        protected void lihatDataPemilik(object sender, EventArgs e)
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

        protected void hapusDataPemilik(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["postgresdb"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Delete from pemilik_kos where id_pemilik=@id_pemilik";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@id_pemilik", Pemilik.Text));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    Pemilik.Text = "";
                    lblmessagePemilik.Text = "Data Has been Deleted";
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }

        protected void lihatDataPenyewaan(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["postgresdb"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Select * from penyewaan";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dtl = new DataTable();
                    da.Fill(dtl);
                    cmd.Dispose();
                    connection.Close();

                    GridView3.DataSource = dtl;
                    GridView3.DataBind();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }

    }

}
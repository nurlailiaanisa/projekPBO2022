using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projek
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tambahDataKos(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["postgresdb"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Insert into data_kos(nama_kos,jenis,pemilik,fasilitas,lokasi,harga,stok) values (@nama_kos,@jenis,@pemilik,@fasilitas,@lokasi,@harga,@stok)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@nama_kos", NamaKos.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@jenis", Jenis.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@pemilik", ID_pemilik.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@fasilitas", Fasilitas.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@lokasi", Lokasi.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga", Convert.ToInt32(Harga.Text)));
                    cmd.Parameters.Add(new NpgsqlParameter("@stok", Convert.ToInt32(Stok.Text)));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    NamaKos.Text = "";
                    Jenis.Text = "";
                    ID_pemilik.Text = "";
                    Fasilitas.Text = "";
                    Lokasi.Text = "";
                    Harga.Text = "";
                    Stok.Text = "";
                    lblmsg.Text = "Berhasil ditambahkan";
                }
            }
            catch (Exception ex) { 
            
                Console.WriteLine(ex.Message);
            
            }
        }

        protected void ubahDataKos(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["postgresdb"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update data_kos set nama_kos=@nama_kos, jenis=@jenis, pemilik=@pemilik,fasilitas=@fasilitas,lokasi=@lokasi,harga=@harga,stok=@stok where id_kos=@idkos ";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@nama_kos", NamaKos.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@jenis", Jenis.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@pemilik", ID_pemilik.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@fasilitas", Fasilitas.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@lokasi", Lokasi.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga", Convert.ToInt32(Harga.Text)));
                    cmd.Parameters.Add(new NpgsqlParameter("@stok", Convert.ToInt32(Stok.Text)));
                    cmd.Parameters.Add(new NpgsqlParameter("@idkos", Convert.ToInt32(TextBox1.Text)));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    NamaKos.Text = "";
                    Jenis.Text = "";
                    ID_pemilik.Text = "";
                    Fasilitas.Text = "";
                    Lokasi.Text = "";
                    Harga.Text = "";
                    Stok.Text = "";
                    TextBox1.Text = "";
                    lblmsg.Text = "Berhasil Diubah";

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }

        protected void lihatDataKos(object sender, EventArgs e)
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

        protected void hapusDataKos(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["postgresdb"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Delete from data_kos where id_kos=@id_kos";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@id_kos", ID_kos.Text));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    ID_kos.Text = "";
                    lblmessage.Text = "Berhasil Dihapus";
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }

    }
}
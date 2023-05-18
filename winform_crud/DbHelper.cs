using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace winform_crud
{
    class CrudPg
    {
        public static void CreateData(string nama, string deskripsi, string provinsi, string kota, string kecamatan, string jalan, int tarif, string luas)
        {
            ConnectPg koneksidb = new ConnectPg();
            string querycreate = $"insert into tujuan.destinasi (nama_destinasi, deskripsi_wisata, provinsi, kota, kecamatan, nama_jalan, tarif_harga, luas_wilayah) values ('{nama}', '{deskripsi}', '{provinsi}', '{kota}', '{kecamatan}', '{jalan}', {tarif}, '{luas}');";
            koneksidb.EksekusiSQL(querycreate);
        }
        public static DataTable ReadData()
        {
            ConnectPg koneksidb = new ConnectPg();
            DataTable dt = koneksidb.EksekusiSQL("select * from tujuan.destinasi");

            return dt;
        }
        public static void UpdateData(string nama, string deskripsi, string provinsi, string kota, string kecamatan, string jalan, int tarif, string luas, int id_destinasi)
        {
            ConnectPg koneksidb = new ConnectPg();
            string queryupdate = $"update tujuan.destinasi set nama_destinasi = '{nama}', deskripsi_wisata = '{deskripsi}', provinsi = '{provinsi}', kota = '{kota}', kecamatan = '{kecamatan}', nama_jalan = '{jalan}', tarif_harga = {tarif}, luas_wilayah = '{luas}' where id_destinasi = {id_destinasi}";
            koneksidb.EksekusiSQL(queryupdate);
        }
        public static void DeleteData(int id_destinasi)
        {
            ConnectPg koneksidb = new ConnectPg();
            string querydelete = $"delete from tujuan.destinasi where id_destinasi = {id_destinasi}::integer;;";
            koneksidb.EksekusiSQL(querydelete);
        }

    }

    class ConnectPg
    {
        public NpgsqlConnection koneksi;

        public ConnectPg()
        {
            NpgsqlConnection koneksi = new NpgsqlConnection();
            koneksi.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=root;Database=pariwisata";
        }

        public DataTable EksekusiSQL(string sintaks)
        {
            NpgsqlConnection koneksi = new NpgsqlConnection();
            koneksi.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=root;Database=pariwisata";

            DataTable dt = new DataTable();
            try
            {
                koneksi.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = koneksi;
                cmd.CommandText = sintaks;
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                cmd.Dispose();
                koneksi.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return dt;
        }
    }
}

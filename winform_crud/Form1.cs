using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_crud
{
    public partial class Form1 : Form
    {

        private int id_destinasi;
        public Form1()
        {
            InitializeComponent();
        }
        void loadgrid()
        {
            dataGridView1.DataSource = CrudPg.ReadData();
            dataGridView1.Columns[0].Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nama.Text = "";
            deskripsi.Text = "";
            provinsi.Text = "";
            kota.Text = "";
            kecamatan.Text = "";
            jalan.Text = "";
            tarif.Text = "";
            luas.Text = "";

            dataGridView1.CurrentRow.Selected = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrudPg.CreateData(nama.Text, deskripsi.Text, provinsi.Text, kota.Text, kecamatan.Text, jalan.Text, Convert.ToInt32(tarif.Text), luas.Text);
            loadgrid();
            nama.Text = "";
            deskripsi.Text = "";
            provinsi.Text = "";
            kota.Text = "";
            kecamatan.Text = "";
            jalan.Text = "";
            tarif.Text = "";
            luas.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id_destinasi == 0)
            {
                MessageBox.Show("Pilih baris dahulu", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CrudPg.UpdateData(nama.Text, deskripsi.Text, provinsi.Text, kota.Text, kecamatan.Text, jalan.Text, Convert.ToInt32(tarif.Text), luas.Text, id_destinasi);
                loadgrid();
                
                nama.Text = "";
                deskripsi.Text = "";
                provinsi.Text = "";
                kota.Text = "";
                kecamatan.Text = "";
                jalan.Text = "";
                tarif.Text = "";
                luas.Text = "";

                dataGridView1.CurrentRow.Selected = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            id_destinasi = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            nama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            deskripsi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            provinsi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            kota.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            kecamatan.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            jalan.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            tarif.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            luas.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (id_destinasi == 0)
            {
                MessageBox.Show("Pilih baris dahulu", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CrudPg.DeleteData(id_destinasi);
                loadgrid();

                nama.Text = "";
                deskripsi.Text = "";
                provinsi.Text = "";
                kota.Text = "";
                kecamatan.Text = "";
                jalan.Text = "";
                tarif.Text = "";
                luas.Text = "";
                dataGridView1.CurrentRow.Selected = false;
            }
        }
    }
}

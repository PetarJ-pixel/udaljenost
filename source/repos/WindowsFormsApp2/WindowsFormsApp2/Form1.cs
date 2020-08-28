using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void sacuvaj_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba();
            osoba.Id = Convert.ToInt32(textId.Text);
            osoba.OIB = textOIB.Text;
            osoba.Ime = textIme.Text;
            osoba.Mjesto = textMjesto.Text;
            osoba.Adresa = textAdresa.Text;
            osoba.Telefon = textTelefon.Text;
            osoba.Email = textMail.Text;
            bool rezultat = SacuvajDetalje(osoba);
            PrikaziStatus(rezultat, "NovaOsoba");
        }
        public bool SacuvajDetalje(Osoba osoba)
        {
            bool rezultat = false;
            using (MbanqEntities _entity = new MbanqEntities())
            {
                _entity.Osobas.Add(osoba);
                _entity.SaveChanges();
                rezultat = true;
            }
            return rezultat;
        }
        public Osoba PodesiVrednosti(int Id, string oib, string ime, string mjesto, string adresa, string telefon, string email)
        {
            Osoba osoba = new Osoba();
            osoba.Id = Convert.ToInt32(textId.Text);
            osoba.OIB = textOIB.Text;
            osoba.Ime = textIme.Text;
            osoba.Mjesto = textMjesto.Text;
            osoba.Adresa = textAdresa.Text;
            osoba.Telefon = textTelefon.Text;
            osoba.Email = textMail.Text;
            return osoba;
        }
        public bool AzurirajOsobu(Osoba os)
        {
            bool rezultat = false;
            using (MbanqEntities _entity = new MbanqEntities())
            {
                Osoba osoba = _entity.Osobas.Where(x => x.Id == os.Id).Select(x => x).FirstOrDefault();
                osoba.OIB = os.OIB;
                osoba.Ime = os.Ime;
                osoba.Mjesto = os.Mjesto;
                osoba.Adresa = os.Adresa;
                osoba.Telefon = os.Telefon;
                osoba.Email = os.Email;
                _entity.SaveChanges();
                rezultat = true;
            }
            return rezultat;
        }
        public void PrikaziStatus(bool rezultat, string Action)
        {
            if (rezultat)
            {
                if (Action == "NovaOsoba")
                {
                    MessageBox.Show("Sacuvano uspesno!..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Action == "Izmjena")
                {
                    MessageBox.Show("Azurirano uspesno!..", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Action == "Brisanje")
                {
                    MessageBox.Show("Ponisteno uspesno..", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Something went wrong!. Please try again!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            OcistiPolja();
        }
        public void OcistiPolja() // cisti sva polja nakon ubacivanja,azuriranja i ponistavanja  
        {
            textId.Text = "";
            textOIB.Text = "";
            textIme.Text = "";
            textMjesto.Text = "";
            textAdresa.Text = "";
            textTelefon.Text = "";
            textMail.Text = "";
        }

        private void izmeni_Click(object sender, EventArgs e)
        {
            Osoba osoba = PodesiVrednosti(Convert.ToInt32(textId.Text), textOIB.Text, textIme.Text, textMjesto.Text, textAdresa.Text, textTelefon.Text, textMail.Text);
            bool rezultat = AzurirajOsobu(osoba);
            PrikaziStatus(rezultat, "Izmjena");
        }

        private void brisanje_Click(object sender, EventArgs e)
        {
            Osoba osoba = PodesiVrednosti(Convert.ToInt32(textId.Text), textOIB.Text, textIme.Text, textMjesto.Text, textAdresa.Text, textTelefon.Text, textMail.Text);
            bool result = PonistiOsobu(osoba);
            PrikaziStatus(result, "Brisanje");
        }
        public bool PonistiOsobu(Osoba os)
        {
            bool rezultat = false;
            using (MbanqEntities entity = new MbanqEntities())
            {
                Osoba osoba = entity.Osobas.Where(x => x.Id == os.Id).Select(x => x).FirstOrDefault();
                entity.Osobas.Remove(osoba);
                entity.SaveChanges();
                rezultat = true;
            }
            return rezultat;
        }
        private void Form1_Load(object sender, EventArgs e)  // Form load Method
        {
            Display();
        }

        public void Display()
        {
            using (MbanqEntities _entity = new MbanqEntities())
            {
                List<Osoba> _osoba = new List<Osoba>();
                _osoba = _entity.Osobas.Select(x => new Osoba
                {
                    Id = x.Id,
                    OIB = x.OIB,
                    Ime = x.Ime,
                    Mjesto = x.Mjesto,
                    Adresa = x.Adresa,
                    Telefon = x.Telefon,
                    Email = x.Email
                }).ToList();
                dataGridView1.DataSource = _osoba;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows) // foreach datagridview selected rows values  
                {
                    textId.Text = row.Cells[0].Value.ToString();
                    textOIB.Text = row.Cells[1].Value.ToString();
                    textIme.Text = row.Cells[2].Value.ToString();
                    textMjesto.Text = row.Cells[3].Value.ToString();
                    textAdresa.Text = row.Cells[4].Value.ToString();
                    textTelefon.Text = row.Cells[5].Value.ToString();
                    textMail.Text = row.Cells[6].Value.ToString();
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mbanqDataSet.Osoba' table. You can move, or remove it, as needed.
            this.osobaTableAdapter.Fill(this.mbanqDataSet.Osoba);
        }

        private void Filterisanje_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[2].HeaderText.ToString() + " LIKE '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void sortiranje_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void izlaz_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Zelite da izadjete iz aplikacije?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }
    }
}

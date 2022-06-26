using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaTech.Forme
{
    public partial class AzurirajLijekForm : Form
    {
        lijek odabraniLijek;
        public AzurirajLijekForm(lijek lijek)
        {
            InitializeComponent();
            odabraniLijek = lijek;
        }

        private void AzurirajLijekForm_Load(object sender, EventArgs e)
        {
            using (var context = new PI2256_DBEntities1())
            {
                txtIdLijeka.Text = odabraniLijek.id_lijek.ToString();
                txtNazivLijeka.Text = odabraniLijek.naziv_lijek;
                txtJedinicaMjere.Text = odabraniLijek.jedinica_mjere;
                txtRokTrajanja.Text = odabraniLijek.rok_trajanja;
                txtNacinPrimjene.Text = odabraniLijek.nacin_primjene;
                if(odabraniLijek.potreban_recept == "Da")
                {
                    chcPotrebanRecept.Checked = true;
                }
                else
                {
                    chcPotrebanRecept.Checked = false;
                }
                txtCijena.Text = odabraniLijek.cijena.ToString();
                txtNabavnaCijena.Text = odabraniLijek.nabavna_cijena.ToString();
                txtKolicinaNaZalihi.Text = odabraniLijek.kolicina_na_zalihi.ToString();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            using (var context = new PI2256_DBEntities1())
            {
                context.lijeks.Attach(odabraniLijek);

               
                odabraniLijek.naziv_lijek = txtNazivLijeka.Text;
                odabraniLijek.jedinica_mjere = txtJedinicaMjere.Text;
                odabraniLijek.rok_trajanja = txtRokTrajanja.Text;
                odabraniLijek.nacin_primjene = txtNacinPrimjene.Text;
                if (chcPotrebanRecept.Checked == true)
                {
                    odabraniLijek.potreban_recept = "Da";
                }
                else
                {
                    odabraniLijek.potreban_recept = "Ne";
                }
                odabraniLijek.cijena = double.Parse(txtCijena.Text);
                odabraniLijek.nabavna_cijena = double.Parse(txtNabavnaCijena.Text);
                odabraniLijek.kolicina_na_zalihi = int.Parse(txtKolicinaNaZalihi.Text);

                context.SaveChanges();
            }
            Close();
        }
    }
}

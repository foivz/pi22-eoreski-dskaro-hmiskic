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
    public partial class GlavnaForm : Form
    {
        private PrijavaForm prijavaForm;
        public string kor_ime = string.Empty;
        public GlavnaForm(PrijavaForm drugaForma)
        {
            InitializeComponent();
            prijavaForm = drugaForma;
        }

        private void btnPregledInventura_Click(object sender, EventArgs e)
        {
            PregledInventura pregledInventura = new PregledInventura();
            pregledInventura.ShowDialog();
        }

        private void btnPregledNarudzbi_Click(object sender, EventArgs e)
        {
            PregledNarudzbenica pregledNarudzbenica = new PregledNarudzbenica();
            pregledNarudzbenica.ShowDialog();
        }

        private void btnPregledPrimki_Click(object sender, EventArgs e)
        {
            PregledPrimki pregledPrimki = new PregledPrimki();
            pregledPrimki.ShowDialog();
        }

        private void btnPregledLijekova_Click(object sender, EventArgs e)
        {
            PregledLijekovaForm pregledLijekovaForm = new PregledLijekovaForm();
            pregledLijekovaForm.ShowDialog();
        }

        private void btnPregledZaposlenika_Click(object sender, EventArgs e)
        {
            PregledZaposlenika pregledZaposlenika = new PregledZaposlenika();
            pregledZaposlenika.ShowDialog();
        }

        private void GlavnaForm_Load(object sender, EventArgs e)
        {
            kor_ime = prijavaForm.strVar.ToString();
            Autentifikator.ValidirajUlogu(kor_ime);
            if (Autentifikator.uspjeh2 == true)
            {
                btnPregledZaposlenika.Visible = true;
            }
            else
            {
                btnPregledZaposlenika.Enabled = false;
            }
        }

        private void btnKreiranjeRacuna_Click(object sender, EventArgs e)
        {
            KreirajRacun kreirajRacun = new KreirajRacun(this);
            kreirajRacun.ShowDialog();
        }

        private void btnIzvjesca_Click(object sender, EventArgs e)
        {
            Izvjesca izvjescaForm = new Izvjesca();
            izvjescaForm.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaTech.Forme;

namespace PharmaTech.UserControle
{
    public partial class StavkaInventure : UserControl
    {
        private List<lijek> Lijekovi = null;
        private KreirajInventurniList Forma = null;
        public StavkaInventure(List<lijek> lijekovi, KreirajInventurniList kreirajForm)
        {
            Lijekovi = lijekovi;
            Forma = kreirajForm;
            InitializeComponent();
        }


        private void StavkaInventure_Load(object sender, EventArgs e)
        {
            DohvatiLijekove();
            uxKolicinaNaZalihi.ReadOnly = true;
            uxRazlika.ReadOnly = true;
            uxStvarnaKolicina.ReadOnly = true;

        }
       


        //dohvaćanje naziva artikala i spremanje u combobox
        private void DohvatiLijekove()
        {
            foreach (var item in Lijekovi.OrderBy(x => x.naziv_lijek))
            {
                uxNaziv.Items.Add(item.naziv_lijek);
            }
        }
    }
}

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
    public partial class StavkaPrimke : UserControl
    {
        private List<lijek> Lijekovi = null;
        private ZaprimanjeLijekova Forma = null;
        public StavkaPrimke(List<lijek> lijekovi, ZaprimanjeLijekova kreirajForm)
        {
            Lijekovi = lijekovi;
            Forma = kreirajForm;
            InitializeComponent();
        }
        private void DohvatiLijekove()
        {
            foreach (var item in Lijekovi.OrderBy(x => x.naziv_lijek))
            {
                uxNazivLijeka.Items.Add(item.naziv_lijek);
            }
        }


     
        public void AzurirajKolicunuLijeka(lijek lijek, int kolicina, int idPrimke)
        {
            using (var context = new PI2256_DBEntities1())
            {

                stavka_primke stavka_Primke = new stavka_primke
                {
                    id_lijek = lijek.id_lijek,
                    id_primka = idPrimke,
                    primljena_kolicina = kolicina
                    


                };
                context.stavka_primke.Add(stavka_Primke);
                context.SaveChanges();

                context.lijeks.Attach(lijek);
                lijek.kolicina_na_zalihi = lijek.kolicina_na_zalihi + kolicina;
                context.SaveChanges();
            }
        }


        public void AzurirajLijek(int idPrimke)
        {
            lijek lijek = null;
            lijek = Lijekovi.FirstOrDefault(r => r.naziv_lijek == uxNazivLijeka.Text);
            if (lijek == null || uxPrimljenaKolicina.Text == "") return;
            else
            {
                int kolicina = int.Parse(uxPrimljenaKolicina.Text);
                AzurirajKolicunuLijeka(lijek, kolicina, idPrimke);
            }
        }

        private void uxIzbrisi_Click(object sender, EventArgs e)
        {
            Forma.Izbrisi(this);
        }

        private void StavkaPrimke_Load(object sender, EventArgs e)
        {
            DohvatiLijekove();

        }
    }
}

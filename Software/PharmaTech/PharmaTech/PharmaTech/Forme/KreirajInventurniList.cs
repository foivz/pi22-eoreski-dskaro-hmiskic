using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaTech.UserControle;
using PharmaTech.Forme;

namespace PharmaTech.Forme
{
    public partial class KreirajInventurniList : Form
    {
        List<lijek> lijekovi = null;
        
        
        public KreirajInventurniList()
        {
            InitializeComponent();
            lijekovi = DohvatiSveLijekove();
            DohvatiZaposlenike();

        }

        private List<lijek> DohvatiSveLijekove()
        {
            using (var context = new PI2256_DBEntities1())
            {
                return context.lijeks.ToList();
            }
        }
        private void DohvatiZaposlenike()
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from zaposlenik in context.zaposleniks
                           select zaposlenik.ime_prezime;
                cbZaposlenik.DataSource = upit.ToList();

            }


        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            uxStavke.Controls.Add(new StavkaInventure(lijekovi, this));

        }
        public void Izbrisi(StavkaInventure odabranaKontrola)
        {
            uxStavke.Controls.Remove(odabranaKontrola);
            odabranaKontrola.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {


            DialogResult dialog = MessageBox.Show("Želite li spremiti stavke?", "Spremanje", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                int idOdabrani;
                using (var context = new PI2256_DBEntities1())
                {
                    var upit = from zaposlenik in context.zaposleniks
                               where zaposlenik.ime_prezime == cbZaposlenik.SelectedItem.ToString()
                               select zaposlenik;
                    idOdabrani = upit.FirstOrDefault().id_zaposlenik;



                }
                int brojac = 0;
                int id=0;



                foreach (StavkaInventure item in uxStavke.Controls)
                {

                    brojac++;
                    if (brojac == 1)
                    {
                        using (var context = new PI2256_DBEntities1())
                        {
                            int idInvent = context.inventuras.Count() + 1;
                            try
                            {

                                inventura inv = new inventura
                                {
                                    id_inventura = idInvent,
                                    datum_pocetka = dtpDatum.Value,
                                    id_zaposlenik = idOdabrani

                                };

                                id = inv.id_inventura;
                                context.inventuras.Add(inv);
                                context.SaveChanges();
                            }
                            catch
                            {
                                MessageBox.Show("Spremanje nije uspjelo.");
                            }
                        }
                    }
                    item.AzurirajLijek(id);

                   }

                    if (brojac > 0)
                    {
                        
                        MessageBox.Show("Lijekovi su ažuriani");
                    using (var context = new PI2256_DBEntities1())
                    {
                        var upit = from stavka_inventure in context.stavka_inventure
                                   join lijek in context.lijeks on stavka_inventure.id_lijek equals lijek.id_lijek
                                   where stavka_inventure.id_inventura == id
                                   select new
                                   {
                                       
                                       Inventura_id = stavka_inventure.id_inventura,
                                       Lijek = lijek.naziv_lijek,
                                       Kolicina_na_zalihi = lijek.kolicina_na_zalihi,
                                       Stvara_kolicina = stavka_inventure.stvarna_kolicina,
                                       Razlika = Math.Abs(lijek.kolicina_na_zalihi - stavka_inventure.stvarna_kolicina)



                                   };
                        dgvStavke.DataSource = upit.ToList();

                    }


                }else{
                        MessageBox.Show("Niste dodali ni jedan lijek!");
                    }
                
                                           }
            else if (dialog == DialogResult.No)
            {
                var uc = uxStavke.Controls.OfType<StavkaInventure>().ToList();
                foreach (var item in uc)
                {
                    uxStavke.Controls.Remove(item);
                    item.Dispose();
                }
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
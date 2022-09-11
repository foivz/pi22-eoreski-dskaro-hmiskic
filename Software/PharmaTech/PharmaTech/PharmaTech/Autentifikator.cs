
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTech
{
    public class Autentifikator
    {
        private static int ulogaID;
        public static bool uspjeh = false;
        public static bool uspjeh2 = false;

        public static void ValidirajPrijavu(string korime, string lozinka)
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from zaposlenik in context.zaposleniks
                           join uloga in context.ulogas
                           on zaposlenik.id_uloge equals uloga.id_uloga
                           where zaposlenik.korisnicko_ime == korime && zaposlenik.lozinka == lozinka && zaposlenik.id_statusa == 1
                           select zaposlenik;
                if (upit.FirstOrDefault() != null)
                {
                    ulogaID = upit.FirstOrDefault().id_uloge;
                    uspjeh = true;
                }
            }
        }

        public static void ValidirajUlogu(string korime)
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from zaposlenik in context.zaposleniks
                           where zaposlenik.korisnicko_ime == korime && zaposlenik.id_uloge == 3
                           select zaposlenik;
                if (upit.FirstOrDefault() != null)
                {
                    uspjeh2 = true;
                }
            }
        }
    }
}

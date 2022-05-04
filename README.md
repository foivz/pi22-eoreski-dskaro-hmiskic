
# PharmaTech 

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Eva Oreški | eoreski@foi.hr | 0119048553 | eoreski
Dominik Škaro | dskaro@foi.hr | 0035224037 | dskaro
Hana Miškić | hmiskic@foi.hr | 1191244974| hmiskic


## Opis domene
Programska potpora za rad ljekarne. Ovu aplikaciju bi koristile zaposlene osobe unutar ljekarne. Postojale bi dvije uloge - admin i zaposlenik. Osnovna domena rada aplikacije bi bila- praćenje količine i vrste lijekova, naručivanje lijekova, izdavanje računa, dodavanje novih lijekova u bazu, upravljanje korisničkim računima zaposlenika, pregled mjesečnih izvadaka, zarade...

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 |Prijava  | Za pristup aplikaciji potrebno se autentificirati pomoću login funkcionalnosti. Korisnik se logira s podacima koji su mu dodijeljeni od strane nadležne osobe. | Eva Oreški
F02 |Pregled lijekova  | Vidljiv ispis svih lijekova u bazi podataka, zalihe za svaki od njih, njihovo pretraživanje, sortiranje i filtrianje, pregled detaljnijeg opisa svakog lijeka, preporučene količine...  | Eva Oreški
F03 |Upravljanje lijekovima | Ova funkcionalnost omogućuje kreiranje, čitanje, ažurianje i brisanje lijekova iz baze podataka(CRUD operacije) | Eva Oreški
F04 |Inventura| Funkcionalnost koja omogućuje provedbu inventure, podatke o njenom izvršavanju- datum, vrijeme, odgovorne osobe, količine robe...| Hana Miškić
F05 |Naručivanje  | Aplikacija će imati ugrađenu mogućnost naručivanja potrebne robe koja nedostaje, to jest automatsko izrađivanje naružbenice popunjavanjem odrđenih podataka. | Hana Miškić
F06 |Zaprimanje | Funkcionalnost koja omogućuje zaprimanje novih lijekova u baze, bit će vidljiv datum i vrijeme. Pomoću nje ćemo uspoređivati količinu zaprimljene robe s količinom na narudžbenici |Hana Miškić
F07 |Kreiranje računa  |Pomoću ove funkcionalnosti možemo kreirati račun te imamo mogućnost njegova storniranja.| Dominik Škaro
F08 |Upravljanje korisničkim računima zaposlenika | Dodavanje korisničkih računa zaposlenika/ mijenjanje statusa zaposlenika(trenutni zaposlenik/bivši zaposlenik)  | Dominik Škaro
F09 |Izvješća | Izvješća o količini prodanih lijekova te grafički prikaz istog, prikaz mjesečnih izvadaka. Također će postojati mogućnost sortiranja i filtrianja.Račun će također biti u obliku izvješća i bit će omogućeno generiranje PDF-a. | Dominik Škaro

## Tehnologije i oprema
- Microsoft Visual Studio 2022
- C# (.NET Framework)
- Microsoft SQL Server
- GitHub
- GitHub Classroom
- Microsoft Word
- Draw.io

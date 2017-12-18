using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWitz
{
    public class Artikel
    {
        public Artikel()
        {
            artikelOid = 0;
            artikelNr = "";
            Bezeichnung = "";
            bestand = 0;
            meldebestand = 0;
            verpackung = 0;
            vkPreis = 0m;
            letzteEntnahme = DateTime.MinValue;
        }


        Int32 artikelOid;
        String artikelNr;
        Int32 artikelGruppe;
        String bezeichnung;
        UInt16 bestand;
        Int16 meldebestand;
        Int32 verpackung;
        Decimal vkPreis;
        DateTime letzteEntnahme;

        public int ArtikelOid
        {
            get
            {
                return artikelOid;
            }

            set
            {
                artikelOid = value;
            }
        }

        public string ArtikelNr
        {
            get
            {
                return artikelNr;
            }

            set
            {
                artikelNr = value;
            }
        }

        public int ArtikelGruppe
        {
            get
            {
                return artikelGruppe;
            }

            set
            {
                artikelGruppe = value;
            }
        }

        public string Bezeichnung
        {
            get
            {
                return bezeichnung;
            }

            set
            {
                bezeichnung = value;
            }
        }

    


        public int Verpackung
        {
            get
            {
                return verpackung;
            }

            set
            {
                verpackung = value;
            }
        }

        public decimal VkPreis
        {
            get
            {
                return vkPreis;
            }

            set
            {
                vkPreis = value;
            }
        }

        public DateTime LetzteEntnahme
        {
            get
            {
                return letzteEntnahme;
            }

            set
            {
                letzteEntnahme = value;
            }
        }

        

        public short Meldebestand
        {
            get
            {
                return meldebestand;
            }

            set
            {
                meldebestand = value;
            }
        }

        public ushort Bestand
        {
            get
            {
                return bestand;
            }

            set
            {
                bestand = value;
            }
        }

        public override string ToString()
        {
            return String.Format (ArtikelOid+". "+ Bezeichnung+" - "+Bestand);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseWitz
{
    public partial class DatabaseDing : Form
    {
        Artikel a;
        DialogResult dr=DialogResult.OK;

        public DialogResult Dr
        {
            get
            {
                return dr;
            }

            set
            {
                dr = value;
            }
        }

        public Artikel A
        {
            get
            {
                return a;
            }

            private set
            {
                a = value;
            }
        }

        public DatabaseDing()
        {
            InitializeComponent();
        }
        public DatabaseDing(Artikel a)
        {
            this.A = a;
            InitializeComponent();
            inizilizeboi();


        }

        private void inizilizeboi()
        {
            textBoxArtikelOID.Text = A.ArtikelOid.ToString();
            textBoxArtikelNUmmer.Text = A.ArtikelNr.ToString();
            textBoxArtikelGruppe.Text = A.ArtikelGruppe.ToString();
            textBoxBezeichnung.Text = A.Bezeichnung;
            textBoxBestand.Text = A.Bestand.ToString();
            textBoxMeldebestand.Text = A.Meldebestand.ToString();
            textBoxVerpackung.Text = A.Verpackung.ToString();
            textBoxVKPreis.Text = A.VkPreis.ToString();
            textBoxLetzteEntnahme.Text = A.LetzteEntnahme.ToShortDateString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            A.ArtikelNr = textBoxArtikelNUmmer.Text;
            A.Bezeichnung = textBoxBezeichnung.Text;
            A.Bestand = Convert.ToByte(textBoxBestand.Text);
            A.Meldebestand= Convert.ToInt16(textBoxMeldebestand.Text);
            A.VkPreis = Convert.ToDecimal(textBoxVKPreis.Text);
            A.LetzteEntnahme = Convert.ToDateTime(textBoxLetzteEntnahme.Text);
            this.Close();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
            this.dr = DialogResult.Cancel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CasinoBeta
{
    public partial class frmOtoslotto : Form
    {
        DB adatbazis;
        User felhasznalo;

        public frmOtoslotto(DB adatbazis, User felhasznalo)
        {
            this.felhasznalo = felhasznalo;
            this.adatbazis = adatbazis;

            InitializeComponent();
            lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
            lblAktiv.TextAlign = ContentAlignment.MiddleRight;
        }
    }
}

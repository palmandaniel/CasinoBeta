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
    public partial class frmBlackJack : Form
    {
        DB adatbazis;
        User felhasznalo;

        public frmBlackJack(DB adatbazis, User felhasznalo)
        {
            this.adatbazis = adatbazis;
            this.felhasznalo = felhasznalo;

            InitializeComponent();
        }
    }
}

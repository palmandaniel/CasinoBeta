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
    public partial class frmKockaPoker : Form
    {
        DB adatbazis;
        User felhasznalo;

        public frmKockaPoker(DB adatbazis, User felhasznalo)
        {
            InitializeComponent();
        }
    }
}

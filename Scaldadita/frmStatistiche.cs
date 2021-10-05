using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scaldadita
{
    public partial class frmStatistiche : Form
    {
        public frmStatistiche()
        {
            InitializeComponent();
        }

        public Scaldadita ScaldaditaDefinitivo;

        private void frmStatistiche_Load(object sender, EventArgs e)
        {
            ScaldaditaDefinitivo.VisualizzaStatistiche(lblWPM, lblCPM, lblErrate, lblBackspace, lblBattuti, lblTempo, lblCharErrati);
        }
    }
}

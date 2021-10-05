using System;
using System.Drawing;
using System.Windows.Forms;

namespace Scaldadita
{
    public partial class frmImpostazioni : Form
    {
        public int TempoDiGioco;
        public string TipoDiParole;
        public event EventHandler TempoNonImpostato;
        public event EventHandler TipoDiParoleNonImpostato;
        private bool ChiusoDaCodice = false;

        public frmImpostazioni()
        {
            InitializeComponent();
        }

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            //Assegno gestori ai relativi eventi...
            TempoNonImpostato += GestisciTempoNonImpostato;
            TipoDiParoleNonImpostato += GestisciTipoParoleNonImpostato;           
        }

        private void GestisciTipoParoleNonImpostato(object sender, EventArgs e)
        {       
            //Se l'utente non imposta alcuna parola lo Scaldadita automaticamente imposterà PAROLE ITALIANE...
            TipoDiParole = "PAROLE ITALIANE";
        }

        private void GestisciTempoNonImpostato(object sender, EventArgs e)
        {
            //Se l'utente non imposta alcun tempo di gioco lo Scaldadita automaticamente imposterà 60sec...
            TempoDiGioco = 60;
        }

        private void plsComeSiGioca_Click(object sender, EventArgs e)
        {
            //Allargo la form per far vedere il "come si gioca"...
            Size = new Size(1072, 466);
        }

        private void plsAvvia_Click(object sender, EventArgs e)
        {
            //Vedo se tutto pronto per partire...
            ControllaSeTuttoImpostato();

            //Chiudo la form corrente...
            ChiusoDaCodice = true;
            Close();            
        }

        private void ControllaSeTuttoImpostato()
        {
            //Se l'utente non ha selezionato tempo di gioco
            if (TempoDiGioco == 0)
                //Se non ha neppure selezionato il tipo di parole
                if (TipoDiParole == null)
                {
                    TempoNonImpostato(this, new EventArgs());
                    TipoDiParoleNonImpostato(this, new EventArgs());
                }
                else
                    TempoNonImpostato(this, new EventArgs());
            else
                //Se non ha selezionato solo il tipo di parole...
                if (TipoDiParole == null)
                {
                    if (TempoDiGioco == 0)
                    {
                        TempoNonImpostato(this, new EventArgs());
                        TipoDiParoleNonImpostato(this, new EventArgs());
                    }
                    else
                        TipoDiParoleNonImpostato(this, new EventArgs());
                }                
        }

        //Da qui gestisco tutti i checked dei Radio Button...
        private void rdb30_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb30.Checked)
            {
                TempoDiGioco = 30;
                rdb60.Checked = false;
                rdb120.Checked = false;
            }
        }

        private void rdb60_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb60.Checked)
            {
                TempoDiGioco = 60;
                rdb30.Checked = false;
                rdb120.Checked = false;
            }
        }

        private void rdb120_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb120.Checked)
            {
                TempoDiGioco = 120;
                rdb30.Checked = false;
                rdb60.Checked = false;
            }
        }

        private void rdbCognomi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCognomi.Checked)
            {
                TipoDiParole = "COGNOMI";
                rdbNomiPropri.Checked = false;
                rdbParoleInglesi.Checked = false;
                rdbParoleItaliane.Checked = false;
            }
        }

        private void rdbNomiPropri_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNomiPropri.Checked)
            {
                TipoDiParole = "NOMI PROPRI";
                rdbCognomi.Checked = false;
                rdbParoleInglesi.Checked = false;
                rdbParoleItaliane.Checked = false;
            }
        }

        private void rdbParoleInglesi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbParoleInglesi.Checked)
            {
                TipoDiParole = "PAROLE INGLESI";
                rdbCognomi.Checked = false;
                rdbNomiPropri.Checked = false;
                rdbParoleItaliane.Checked = false;
            }
        }

        private void rdbParoleItaliane_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbParoleItaliane.Checked)
            {
                TipoDiParole = "PAROLE ITALIANE";
                rdbCognomi.Checked = false;
                rdbParoleInglesi.Checked = false;
                rdbNomiPropri.Checked = false;
            }
        }


        private void frmImpostazioni_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Se la form è stata chiusa dal pulsante "X" arresta brutalmente il processo...
            if (e.CloseReason == CloseReason.UserClosing && ChiusoDaCodice == false)
            {
                Environment.Exit(0);
            }
        }
    }
}

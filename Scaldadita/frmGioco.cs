using System;
using System.Windows.Forms;

namespace Scaldadita
{
    public partial class frmGioco : Form
    {
        public frmGioco()
        {
            InitializeComponent();
        }

        Scaldadita mioScaldadita;

        private void frmGioco_Load(object sender, EventArgs e)
        {
            //Apro la form delle impostazioni...
            frmImpostazioni Settings = new frmImpostazioni();
            Settings.ShowDialog();

            //Assegno i valori presi dalla form delle impostazioni a variabili locali
            int TempoDiGioco = Settings.TempoDiGioco;
            string TipoDiParole = Settings.TipoDiParole;

            //Creo l'oggetto Scaldadita e assegno evento...
            mioScaldadita = new Scaldadita(TipoDiParole, TempoDiGioco, dgvParole, lblParolaCorrente, lblProssimaParola);
            mioScaldadita.TempoScaduto += GestisciTempoScaduto;

            //Visualizzo parola corrente e successiva nelle apposite label
            mioScaldadita.VisualizzaParolaCorrenteESuccessiva(lblParolaCorrente, lblProssimaParola);

            //Faccio partire il timer...
            mioTimer.Start();

            //Disabilito il resizing manuale della form...
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void txtInputParola_TextChanged(object sender, EventArgs e)
        {          
            //Controllo se è stato premuto lo spazio
            string ParolaInserita = txtInputParola.Text;
            
            if(ParolaInserita.Length != 0)
            {
                if (ParolaInserita[ParolaInserita.Length - 1] == ' ')
                {
                    //Controllo se la parola è uguale a quella data dallo scaldadita (Substring fino a -1 perchè l'ultimo carattere è lo spazio)...
                    mioScaldadita.ControllaSeParolaUguale(ParolaInserita.Substring(0, ParolaInserita.Length - 1));

                    //Azzero la textbox e la metto a fuoco
                    txtInputParola.Clear();
                    txtInputParola.Focus();
                }
                else
                    //Mostro graficamente all'utente se ciò che ha scritto finora è ok...
                    mioScaldadita.ColoreCellaGridView(ParolaInserita);
            }
                            
        }

        private void mioTimer_Tick(object sender, EventArgs e)
        {
            //Metto a fuoco la textbox di input...
            txtInputParola.Focus();

            //Calcolo e visualizzo statistiche...
            mioScaldadita.CalcolaStatistiche();
            mioScaldadita.VisualizzaStatistiche(lblWPM, lblCPM, lblErrate, lblBackspace, lblBattuti, lblTempo, lblCharErrati);
            mioScaldadita.IncrementaSecondiTrascorsi();
        }

        private void txtInputParola_KeyDown(object sender, KeyEventArgs e)
        {
            //Vedo se c'è stato qualche ripensamento...
            mioScaldadita.ControllaSeCaratterePremutoBackspace(e);

            if(e.KeyCode == Keys.Enter)
            {
                //Metto da parte la parola inserita nella textbox...
                string ParolaInserita = txtInputParola.Text;

                //Controllo se la parola corrisponde a quella sottoposta all'utente dallo scaldadita...
                mioScaldadita.ControllaSeParolaUguale(ParolaInserita.Substring(0, ParolaInserita.Length));

                //Inizializzo textbox e metto a fuoco per la prossima parola...
                txtInputParola.Clear();
                txtInputParola.Focus();
            }
        }

        private void GestisciTempoScaduto(object sender, EventArgs e)
        {
            //Fermo il timer e avviso
            mioTimer.Stop();
            MessageBox.Show("TEMPO SCADUTO");

            //Creo la form per la visualizzazione delle statistiche definitive e gliele invio...
            frmStatistiche Stats = new frmStatistiche();
            Stats.ScaldaditaDefinitivo = mioScaldadita;

            //Nascondo la form corrente e attendo che venga chiusa l'altra per poi terminare il programma...
            Hide();
            Stats.ShowDialog();
            Close();
            
        }
    }
}

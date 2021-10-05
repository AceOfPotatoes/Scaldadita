using System;
using System.Windows.Forms;
using System.Drawing;

namespace Scaldadita
{
    public class Scaldadita
    {
        //Creo l'oggetto Dizionario...
        public static Dizionario mioDizionario = new Dizionario();

        //Metto da parte il numero di righe e colonne necessarie per la DGV...
        const int NumeroRighe = 2;
        const int NumeroColonne = 5;

        //Creo l'oggetto casella...
        public CasellaCorrente miaCasella = new CasellaCorrente(NumeroRighe, NumeroColonne);

        //Dichiaro la DGV che utilizzerò per visualizzare le parole...
        private DataGridView dgv;

        //Dichiaro le Label per visualizzare parola corrente e successiva
        Label lblParolaCorrente;
        Label lblParolaSuccessiva;

        //Creo l'oggetto font...
        Font mioFont = new Font("Verdana", 14);

        //DGV.Size = 700;80
        const int AltezzaRigaDGV = 40;
        const int LarghezzaColDGV = 160;
        
        //Dichiaro e inizializzo le variabili necessarie...
        private int ParoleCorrette = 0;
        private int ParoleErrate = 0;
        private float _SecTrasc;
        private float SecondiTrascorsi
        {
            get { return _SecTrasc; }
            set
            {
                if (_SecTrasc >= TempoDiGioco)
                    TempoScaduto(this, new EventArgs());
                else
                    _SecTrasc = value;
            }
        }
        private int TempoDiGioco;
        private float CaratteriDigitati = 0;
        private int WPM = 0;
        private int CPM = 0;
        private int CaratteriErrati = 0;
        private int NumeroBackspacePremuti = 0;

        //Qui inserirò le coordinate della CellaEvidenziata...
        private EventArgs CellaEvidenziata;

        //Evento che scatta al termine del tempo di gioco...
        public event EventHandler TempoScaduto;
       
        //Costruttore...
        public Scaldadita(string NuovoTipoParole, int NuovoTempoDiGioco, DataGridView dgvParole, Label lblCorrente, Label lblSuccessiva)
        {
            dgv = dgvParole;
            CostruisciDGV();
            TempoDiGioco = NuovoTempoDiGioco;
            mioDizionario.CaricaParole(NuovoTipoParole);
            mioDizionario.CreaDizionarioDefinitivo();
            mioDizionario.VisualizzaIn(dgv);
            lblParolaCorrente = lblCorrente;
            lblParolaSuccessiva = lblSuccessiva;
        }

        //Costruisco la DGV
        private void CostruisciDGV()
        {
            //Tolgo alla DGV ciò che non serve
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;

            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;

            dgv.DefaultCellStyle.Font = mioFont;

            // dgv.ScrollBars = 0 -> none -> quindi nessuna barra
            dgv.ScrollBars = 0;

            //Creo le colonne
            for (int k = 0; k < 5; k++)
            {
                dgv.Columns.Add(k.ToString(), "");
                dgv.Columns[k].Width = LarghezzaColDGV;
            }

            //Aggiungo le righe
            dgv.Rows.Add(2);

            for (int k = 0; k < 2; k++)
                dgv.Rows[k].Height = AltezzaRigaDGV;

            dgv.Rows[0].Cells[0].Selected = false;
        }


        public void ControllaSeParolaUguale(string ParolaInserita)
        {
            //Prendo la parola che è stata sottoposta all'utente...
            string PrimaParola = mioDizionario.RestituisciPrimaParolaDizionario();

            //Se le parole coincidono...
            if (ParolaInserita == PrimaParola)
            {
                ParoleCorrette++;
                CaratteriDigitati += ParolaInserita.Length;
                
            }
            //Altrimenti agisci di conseguenza...
            else
            {
                ParoleErrate++;
                CaratteriDigitati += ParolaInserita.Length;
                ControllaCaratteriErrati(ParolaInserita, PrimaParola);
            }
            
            //Tolgo il colore dalla cella corrente...
            CancellaColoreCellaDGV();

            //Passo alla prossima cella...
            ProssimaCella();

            //Cancello la parola appena controllata dal dizionario...
            mioDizionario.EliminaPrimoElementoDizionario();

            //Vedo se devo fare scorrere la DGV...
            ControllaSeAggiornareDGV();        
            
            //Visualizzo parola corrente e successiva nelle label sulla form...
            VisualizzaParolaCorrenteESuccessiva(lblParolaCorrente, lblParolaSuccessiva);
        }
        
        private void CancellaColoreCellaDGV()
        {
            int IndiceRiga = miaCasella.IndiceRiga;
            int IndiceColonna = miaCasella.IndiceColonna;

            dgv[IndiceColonna, IndiceRiga].Style.BackColor = Color.White;
            dgv[IndiceColonna, IndiceRiga].Style.ForeColor = Color.Black;
        }

        public void ColoreCellaGridView(string ParolaInserita)
        {
            int IndiceRiga = miaCasella.IndiceRiga;
            int IndiceColonna = miaCasella.IndiceColonna;

            string PrimaParola = mioDizionario.RestituisciPrimaParolaDizionario();

            //Se ciò che stiamo inserendo è una sottostringa della prima parola (a partire dalla prima lettera) colora verde...
            if (PrimaParola.IndexOf(ParolaInserita) != -1 && PrimaParola.IndexOf(ParolaInserita) < 1)
            {               
                dgv[IndiceColonna, IndiceRiga].Style.BackColor = Color.Green;
                dgv[IndiceColonna, IndiceRiga].Style.ForeColor = Color.White;
            }
            //Altrimenti colora rosso...
            else
            {
                dgv[IndiceColonna, IndiceRiga].Style.BackColor = Color.Red;
                dgv[IndiceColonna, IndiceRiga].Style.ForeColor = Color.White;
            }
        }

        public void CalcolaStatistiche()
        {
            //Parole corrette / tempo trascorso * 60... solo se i secondi trascorsi sono diversi da 0
            if(SecondiTrascorsi != 0)
                CPM = (int)((CaratteriDigitati / SecondiTrascorsi) * 60);

            //Secondo lo standard internazionale WPM = CPM/5...
            WPM = CPM / 5;
        }


        public void IncrementaCaratteriDigitati()
        {
            //Incremento la variabile...
            CaratteriDigitati++;
        }

        //Vedo quanti caratteri della parola confermata sono errati...
        private void ControllaCaratteriErrati(string ParolaInserita, string PrimaParola)
        {
            int LunghezzaParolaInserita = ParolaInserita.Length;
            int LunghezzaPrimaParola = PrimaParola.Length;
            for(int k = 0; k<LunghezzaParolaInserita; k++)
            {
                if (k < LunghezzaPrimaParola)
                    if (PrimaParola[k] != ParolaInserita[k])
                        CaratteriErrati++;                
            }
        }

        public void ControllaSeCaratterePremutoBackspace(KeyEventArgs e)
        {
            //Se il codice del tasto "BackSpace" coincide con quello arrivato come parametro...
            if (e.KeyCode == Keys.Back)
                //Incremento la variabile...
                NumeroBackspacePremuti++;
        }

        public void VisualizzaParolaCorrenteESuccessiva(Label lblParolaCorrente, Label lblParolaSuccessiva)
        {
            lblParolaCorrente.Text = mioDizionario.RestituisciPrimaParolaDizionario();
            lblParolaSuccessiva.Text = mioDizionario.RestituisciSecondaParolaDizionario();
        }

        //Assegno al testo delle Label le varie statistiche...
        public void VisualizzaStatistiche(Label lblWPM, Label lblCPM, Label lblParoleErrate, Label lblBackspace, Label lblBattuti, Label lblTempo, Label lblCharErrati)
        {
            lblTempo.Text = (TempoDiGioco - SecondiTrascorsi).ToString();
            lblWPM.Text = WPM.ToString();
            lblCPM.Text = CPM.ToString();
            lblParoleErrate.Text = ParoleErrate.ToString();
            lblBattuti.Text = CaratteriDigitati.ToString();
            lblBackspace.Text = NumeroBackspacePremuti.ToString();
            lblCharErrati.Text = CaratteriErrati.ToString();
        }

        public void IncrementaSecondiTrascorsi()
        {
            //Incremento la variabile...
            SecondiTrascorsi++;
        }

        public void ImpostaCellaSelezionata(EventArgs Cella)
        {
            //La cella che mi arriva come parametro la metto in CellaEvidenziata...
            CellaEvidenziata = Cella;
        }
        
        public void ControllaSeAggiornareDGV()
        {
            //Se le parole confermate finora sono un multiplo di 5, scala riga...
            if ((ParoleCorrette + ParoleErrate) % 5 == 0)
                mioDizionario.VisualizzaIn(dgv);
        }

        private void ProssimaCella()
        {
            //Incremento la variabile...
            miaCasella.IndiceColonna++;
        }
    }
}

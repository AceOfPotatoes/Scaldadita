using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Scaldadita
{
    public class Dizionario
    {
        //Creo le liste che mi serviranno per creare il dizionario...
        private List<string> Parole = new List<string>();
        private List<string> DizionarioDefinitivo = new List<string>();

        //Evento che dirà se viene richiesto un TipoParole inesistente...
        public event EventHandler TipoParoleErrato;

        public void CaricaParole(string TipoParole)
        {
            StreamReader SR = null;

            switch (TipoParole.ToUpper())
            {
                case "COGNOMI":
                    SR = File.OpenText(@"File Parole//Cognomi.txt");
                    break;

                case "NOMI PROPRI":
                    SR = File.OpenText(@"File Parole//Nomi propri.txt");
                    break;

                case "PAROLE ITALIANE":
                    SR = File.OpenText(@"File Parole//Parole italiane.txt");
                    break;

                case "PAROLE INGLESI":
                    SR = File.OpenText(@"File Parole//Parole inglesi.txt");
                    break;

                default:
                    TipoParoleErrato(this, new EventArgs());
                    break;

            }

            while (!SR.EndOfStream)
            {
                string ParolaDaAggiungere = SR.ReadLine();
                if (ParolaDaAggiungere.Length > 2)
                    Parole.Add(ParolaDaAggiungere);
            }

            SR.Close();
        }

        public void DisordinaParole()
        {
            //Creo oggetto Random...
            Random R = new Random();

            //Disordino la lista Parole...
            for(int k = Parole.Count-1; k>=0; k--)
            {
                int PosizioneCasuale = R.Next(0, Parole.Count - 1);
                string Temp = Parole[PosizioneCasuale];
                Parole[PosizioneCasuale] = Parole[k];
                Parole[k] = Temp;
            }
        }

        public void CreaDizionarioDefinitivo()
        {
            //Creo oggetto Random...
            Random R = new Random();

            //Creo il mio dizionario definitivo di 300 parole...
            for(int k = 0; k<300; k++)
            {
                int PosizioneCasuale = R.Next(Parole.Count);
                DizionarioDefinitivo.Add(Parole[PosizioneCasuale]);
            }

            CancellaElencoCompleto();
        }

        private void CancellaElencoCompleto()
        {
            //Cancello l'elenco di tutte le parole del file...
            Parole.Clear();
        }

        //Visualizzo le parole del dizionario nella DGV dello Scaldadita...
        public void VisualizzaIn(DataGridView dgv)
        {
            int IndiceElemento = 0;
            for(int R = 0; R < 2; R++)
            {
                for(int C = 0; C < 5; C++)
                {
                    dgv[C, R].Value = DizionarioDefinitivo[IndiceElemento];
                    
                    IndiceElemento++;
                }
            }
        }

        public string RestituisciPrimaParolaDizionario()
        {
            //Restituisco la prima parola del dizionario...
            return DizionarioDefinitivo[0];
        }

        public string RestituisciSecondaParolaDizionario()
        {
            //Restituisco la seconda parola del dizionario...
            return DizionarioDefinitivo[1];
        }

        public void EliminaPrimoElementoDizionario()
        {
            //Elimino la prima parola del dizionario...
            DizionarioDefinitivo.RemoveAt(0);
        }
    }
}

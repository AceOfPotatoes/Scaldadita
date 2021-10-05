namespace Scaldadita
{
    public class CasellaCorrente
    {
        private int _IndiceRiga = 0;
        private int _IndiceColonna = 0;
        private int NumeroRighe;
        private int NumeroColonne;

        //Costruttore...
        public CasellaCorrente(int NuovoNumeroRighe, int NuovoNumeroColonne)
        {
            NumeroRighe = NuovoNumeroRighe;
            NumeroColonne = NuovoNumeroColonne;
        }


        public int IndiceColonna
        {
            get { return _IndiceColonna; }
            set
            {
                if (value == NumeroColonne)
                {
                    _IndiceColonna = 0;
                }
                else
                    _IndiceColonna = value;
                    
            }
        }

        public int IndiceRiga
        {
            get { return _IndiceRiga; }
            set { }
        }
    }
}

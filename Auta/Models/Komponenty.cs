namespace Auta.Models
{
    public class Komponenty
    {
        private string nazev = string.Empty;
        private string popis = string.Empty;
        private bool zakoupeno = false;
        private int cena = 0;




        public string Nazev
        {
            get { return nazev; }
            set { nazev = value; }
        }

        public string Popis
        {
            get { return popis; }
            set { popis = value; }
        }

        public bool Zakoupeno
        {
            get { return zakoupeno; }
            set { zakoupeno = value; }
        }
        public int Cena
        {
            get { return cena; }
            set
            {
                if (value < 0)
                {
                    cena = 0;
                }
                else
                {
                    cena = value;
                }
            }
        }


        

    }
}

        
    

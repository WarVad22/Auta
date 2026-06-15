namespace Auta.Models
{
    public class Kategorie
    { 
        private string nazevKategorie = string.Empty;
        private bool jedenVyber = false;
        private bool bylUzJedenVybran = false;
        private List<Komponenty> komponenty = new List<Komponenty>();

        
        
        


        public string NazevKategorie
        {
            get { return nazevKategorie; }
            set { nazevKategorie = value; }
        }

        public bool JedenVyber
        {
            get { return jedenVyber; }
            set { jedenVyber = value; }
        }

        public List<Komponenty> Komponenty
        {
            get { return komponenty; }
            set { komponenty = value; }
        }

        public bool BylUzJedenVybran
        {
            get { return bylUzJedenVybran; }
            set { bylUzJedenVybran = value; }
        }



    }
}

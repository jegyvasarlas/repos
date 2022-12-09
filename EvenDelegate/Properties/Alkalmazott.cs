namespace EvenDelegate
{
    public delegate void EventHandlerDelegate(string uzenet);
    
    class Alkalmazott
    {
        private string nev;
        private int fizetes;

        public int Fizetes
        {
            set
            {
                fizetes = value;
                FizetesEmeles();
            }
        }
        
        public event EventHandlerDelegate FizetesemelesErtesites;
        public Alkalmazott(string nev, int fizetes)
        {
            this.nev = nev;
            this.fizetes= fizetes;
        }
        
        public void FizetesEmeles()
        {
            if(FizetesemelesErtesites != null)
            {
                FizetesemelesErtesites("Fizetés emelés!!!!!!!");
            }
        }
    }
}
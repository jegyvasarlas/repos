namespace IEnumerator_es_IEnumerable
{
    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }
    
    public interface IEnumerator
    {
        bool MoveNext();
        void Reset();
        object Current { get; }
    } 
    
    public class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
    }

    class Program
    {
        public static void Main()
        {
            
        }
    }
}
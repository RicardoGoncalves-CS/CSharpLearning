namespace AdvancedNUnit
{
    public class Counter
    {
        // Properties
        public int Count { get; private set; }
        
        // Constructor
        public Counter(int start) { Count = start; }
        
        //Methods
        public void Increment() { Count++; }
        public void Decrement() { Count--; }
    }
}

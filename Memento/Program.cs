namespace Memento
{
    public class document
    {
        public document(string title, string content) 
        {
            this.title = title;
            this.content = content;
        }

        public string title { get; set; }
        public string content { get; set; }
        
        public void show() 
        {
            Console.WriteLine(title + " /// " + content);
        }

        public memento snapshot()
        {
            memento temp = new memento(title, content);
            return temp;
            //return new memento(title, content);
        }

        public void restore(memento history)
        {
            this.title = history.title;
            this.content = history.content;
        }
    }

    public class memento
    {
        public memento(string title, string content)
        {
            this.title = title;
            this.content = content;
        }

        public string title { get; }
        public string content { get; }

        public void show()
        {
            Console.WriteLine(title + " /// " + content);
        }
    }

    public class caretaker
    {
        public Stack<memento> listcopy = new Stack<memento>();

        public void saveStatus(document raw)
        {
            memento temp = raw.snapshot();
            listcopy.Push(temp);

            //listcopy.Push(raw.snapshot());
        }

        public void undo(document raw)
        {
            memento mem = listcopy.Pop();
            raw.restore(mem);

            //raw.restore(listcopy.Pop());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            document tailieu = new document("Tai lieu 1", "He lo 1");
            tailieu.show();

            caretaker caretaker = new caretaker();
            caretaker.saveStatus(tailieu);

            tailieu.title = "Tai lieu 2";
            tailieu.content = "He lo 2";
            tailieu.show();
            caretaker.saveStatus(tailieu);

            tailieu.title = "Tai lieu 3";
            tailieu.content = "He lo 3";
            tailieu.show();

            caretaker.undo(tailieu);
            tailieu.show();

            caretaker.undo(tailieu);
            tailieu.show();
        }
    }
}

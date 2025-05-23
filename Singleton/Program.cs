namespace Singleton
{
    class Database
    {
        private Database() { }

        public static Database Instance;

        public static Database GetDatabase()
        {
            if(Instance == null)
            {
                Instance = new Database();
            }    
            return Instance;
        }

        public void ConnectDb()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Database db = Database.GetDatabase();

            db.ConnectDb();
        }
    }
}

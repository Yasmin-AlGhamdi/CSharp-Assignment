using System;

namespace SQLBuilder
{
    class MyBuilder
    {
        private string Value;
        private string v;
        private string w;

        public MyBuilder()
        {
            this.Value = "";
            this.v = "";
            this.w = "";
        }

        public MyBuilder select(string val, string v)
        {
            this.Value += "SELECT " + val + " \nFROM " + v;
            return this;
        }
        public MyBuilder insert(string val, string v)
        {
            this.Value += "\nINSERT INTO " + val + " \nVALUES " + v;
            return this;
        }
        public MyBuilder update(string val, string v, string w)
        {
            this.Value += "\nUPDATE " + val + " \nSET " + v + " \nWHERE " + w;
            return this;
        }
        public MyBuilder delete(string val, string v, string w)
        {
            this.Value += "\nDELETE " + val + " \nFROM " + v + " \nWHERE " + w;

            return this;
        }
        public string get()
        {
            return this.Value;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            MyBuilder sb = new MyBuilder();
            string result = sb.select("*", "employee")
                .insert("employee(id, fname, lname)", "('123', 'Yasmin', 'Alghamdi')")
                .update("employee", "fname = 'Layan'", "id = '123'")
                .delete("", "employee", "id = '123'")
                .get();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

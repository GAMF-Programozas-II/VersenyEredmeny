namespace Verseny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Versenyző versenyző=new Versenyző(12,"Ó Ida",new List<int> {123,345,567});
            //Console.WriteLine(versenyző);
            List<Versenyző> v = new List<Versenyző>(); 
            string[] sorok=File.ReadAllLines("..\\..\\..\\verseny.txt");
            foreach (var item in sorok)
            {
                string[] d = item.Split();
                int id = int.Parse(d[0].Trim('#'));
                string nev = d[1] + " " + d[2];
                List<int> eredmenyek=new List<int>();
                for (int i = 3; i < d.Length; i++)
                {
                    eredmenyek.Add(int.Parse(d[i]));
                }
                v.Add(new Versenyző(id, nev, eredmenyek) );
            }
            foreach (var item in v)
            {
                Console.WriteLine(item);
            }

        }
    }
}

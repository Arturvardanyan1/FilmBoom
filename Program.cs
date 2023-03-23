namespace FilmBoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Anvjar anvjar = new Anvjar();
            vjarovi vjarovi  = new vjarovi();
            Console.WriteLine("yntrel cankali tarberaky");
            Console.WriteLine("1 anvjar " + "2 vjarovi ");
            int i=int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        anvjar.fantasy();
                        break;
                    }
                case 2:
                    {
                        vjarovi.fantasy();
                        break ;
                    }
            }
        }
    }
}
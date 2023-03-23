using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
     class Janrer:Filmer
    {
        Filmer filmer = new Filmer();
        public void fantasy()
        {
            Console.WriteLine("yntrel cankali tarberaky");
            Console.WriteLine("1 Jumanji " + "2 Black Adam");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        filmer.Jumanji();
                        break;
                    }
                case 2:
                    {
                        filmer.BlackAdam();
                        break;
                    }
            }

        }
       
    }
}

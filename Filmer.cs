using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
     class Filmer : Iinfo
    {
        public string nkaragrutyun { get; set ; }
        public string tevoxutyun { get ; set ; }
        public string[] dercucak { get ; set ; }
        public int views { get  ; set; }
        public double star { get ; set ; }

        public void Jumanji()
        {
            dercucak = new string[] { "1 Dwayne Johnson", "2 Kevin Hart", "3 Karen Sheila Gillan", "4 Thomas Jacob Black" };
            nkaragrutyun = "Jumanji is a 1995 American fantasy adventure film directed by Joe Johnston from a screenplay by Jonathan Hensleigh, " +
                "Greg Taylor, and Jim Strain, based on the 1981 children's picture book of the same name by Chris Van Allsburg. ";
            tevoxutyun = "104 minutes";
            Console.WriteLine("glxavor dererum");
            foreach (string s in dercucak)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(nkaragrutyun);
            Console.WriteLine(tevoxutyun);
        }

        public void BlackAdam()
        {
            dercucak = new string[] { "1 Dwayne Johnson", "2 Sarah Shahi", "3 Henry Cavill", "4  Pierce Brendan Brosnan," };
            tevoxutyun = "125 minutes";
            nkaragrutyun = "Black Adam is a 2022 American superhero film based on the DC character of the same name.";
            Console.WriteLine("glxavor dererum");
            foreach (string s in dercucak)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(nkaragrutyun);
            Console.WriteLine(tevoxutyun);
        }

    }
}

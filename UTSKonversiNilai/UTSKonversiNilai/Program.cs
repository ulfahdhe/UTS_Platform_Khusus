using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konversiNilai;

class Program
{
    static void Main(string[] args)
    {

        int nilai;
        
        //Input
       
        Console.Write("Masukan Nilai : ");
        nilai = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        // Console.WriteLine("nilai is {0}.", nilai);
        Console.WriteLine("\n");
        if (nilai >= 75)
        {
            Console.WriteLine("nilai A.", nilai);
        }
        else if (nilai >= 75)
        {
            Console.WriteLine("nilai A.", nilai);
        }
        else if (nilai >= 60)
        {
            Console.WriteLine("nilai B.", nilai);
        }
        else if (nilai >= 50)
        {
            Console.WriteLine("nilai C.", nilai);
        }
        else if (nilai >= 40)
        {
            Console.WriteLine("nilai D.", nilai);
        }
        else
        {
            Console.WriteLine("nilai E.", nilai);
        }
    }
}
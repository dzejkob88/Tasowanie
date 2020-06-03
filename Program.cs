
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string column1;
            string column2;
            List<string> column1final = new List<string>();
            List<string> column2final = new List<string>();
            

            
            using (var rd = new StreamReader(@"f:\filename.csv"))
            {
                while (!rd.EndOfStream)
                {
                    string[] splits = rd.ReadLine().Split(';');
                    column1 = splits[0];
                    column2 = splits[1];
                    column1final = column1.Split(',').ToList();
                    column2final = column2.Split(',').ToList();
                }
                
            }
            
            for (int i = 0; i < column1final.Count; i++)
            {
                Console.WriteLine(column1final[i]);
                Console.WriteLine(column2final[i]);

            }
            Console.ReadKey();
        }
    }
}

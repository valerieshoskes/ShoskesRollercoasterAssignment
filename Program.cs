using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ShoskesRollercoasterAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../../../../Rollercoaster.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(Rollercoaster(line));
                line = reader.ReadLine();
            }
            reader.Close();
        }
        static string Rollercoaster(string text)
        {
            string rideText = "";
            int upperOrLower = 0;
            foreach (char c in text)
            {
                if (char.ToUpper(c) != char.ToLower(c))
                {

                    if (upperOrLower % 2 == 0)
                    {
                        rideText += char.ToUpper(c);
                    }
                    else
                    {
                        rideText += char.ToLower(c);
                    }
                    upperOrLower++;
                }
            }
            return rideText;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_light
{
    class Program
    {
        //green -> yellow ->red

        static void Main(string[] args)
        {
            Console.WriteLine(UpdateLight("green"));
        }


        public static string UpdateLight2(string current)
        {
            switch (current)
            {
                case "green": return "yellow";    
                case "yellow": return "red";   
                case "red": return "green";
                
            }
            return current;
            
        }
        public static string UpdateLight(string current)
        {
            return current == "green" ? "yellow" : current == "yellow" ? "red" : "green";
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FinalPrice());

            Console.WriteLine(CalculateCircleArea(30F));

            Console.ReadLine(); 
        }

        static string FinalPrice()
        {

            var array = new Dictionary<string, int>
            {
                {"Chocolate", 30},
                {"Refrigerante", 50},
                {"Sorvete", 60},
                {"Pão", 15}
            };

            foreach(var item in array)
            {
                float finalPrice = 25F * item.Value / 100;

                Console.WriteLine($"O valor final de {item.Key} é {finalPrice}");
            }

            return "";
        }

        static string CalculateCircleArea(float area)
        {
            
            double circleArea = Math.PI * (area * area);

            Console.WriteLine($"A circunferência perfeita é " + (int)circleArea);

            return ""; 
        }
    }
}

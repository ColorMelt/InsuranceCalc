using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TropicsHomework01
{
    class Program
    {
        


        static void Main(string[] args)
        {
            var helper = new Insured();
            helper.getNumberOfQuotes();
            var q = new List<Insured>();
            for (int i = 0; i < helper.numberOfQuotes; i++)
            {
                q.Add(new Insured());
                
            }
            for (int i = 0; i < helper.numberOfQuotes; i++)
            {
                Console.WriteLine("\nPolicy " + Convert.ToInt32(i+1));
                q[i].getInitialPremium();
                q[i].getPercentages();
            }
            for (int i = 0; i < helper.numberOfQuotes; i++)
            {
                Console.WriteLine("Policy " + Convert.ToInt16(i+1));
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Initial Premium:\t"+ q[i].initialPremium.ToString("C"));

                for (int p = 0; p < 3; p++)
                {
                    Console.WriteLine("Credit " + Convert.ToInt32(p + 1) + " ("+ q[i].Percentages[p] *100  +"%):\t"+ q[i].Credits[p].ToString("C") );
                    //Console.WriteLine("Percentage"+ Convert.ToInt16(p+1) + ": \t"  +  q[i].Percentages[p]);
                }
            }
            Console.ReadLine();

         }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TropicsHomework01
{
    class Insured
    {
        public int initialPremium { get; set; }
        public int numberOfQuotes { get; set; }
        public double[] Percentages { get; set; }
        public double[] Credits { get; set; }
        public void getNumberOfQuotes()
        {
            string input;
            Console.WriteLine("How many quotes would you like to process? ");
            input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[1-5]$"))
            {
                this.numberOfQuotes = Convert.ToInt32(input);
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 5");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public void getPercentages()
        {
            this.Percentages = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Percentage " + Convert.ToInt32(i + 1));
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^[1-9]|1[0-9]?|2[0-5]?$"))
                {
                    this.Percentages[i] = (Convert.ToDouble(input)*.01);
                }
                else if (Regex.IsMatch(input, @"^0[0]?$"))
                {
                    break;
                }
            }
            this.Credits = new double[3];
            this.Credits[0] = this.initialPremium * this.Percentages[0];
            double prem = this.initialPremium - this.Credits[0];
            //Console.WriteLine(this.Credits[0]);
            for (int i = 1; i < 3; i++)
            {
                this.Credits[i] = prem * this.Percentages[i];
                prem -= this.Credits[i];


            }

        }
      


        public void getInitialPremium()
        {
            
            Console.WriteLine("------------------------------");
            Console.WriteLine("Enter the insurance premium: ");
            string input;
            int value;
            input = Console.ReadLine();
            if(Int32.TryParse(input, out value))
            {
                if(Convert.ToInt32(input) >= 0 && Convert.ToInt32(input) <=100000)
                {
                    this.initialPremium = Convert.ToInt32(input);
                }
            }
            else
            {
                Console.WriteLine("Enter a numeric value between 0 and 100000.");
                Environment.Exit(0);
            }
        }
    }
}

using System;

namespace izpitvane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip Calculator App");
            double totalWithoutTaxesAndTip = GetTotalFromUser();
            double taxes = CalculateTaxes(totalWithoutTaxesAndTip);
            PrintTaxes(taxes);
            double totalWithTaxesWithoutTip = totalWithoutTaxesAndTip + taxes;

            //5% Tip
            double tip5Percents = CalculateTip5Percents(totalWithTaxesWithoutTip);
            double overAllTotalWith5PercentTip = totalWithTaxesWithoutTip + tip5Percents;
            PrintTipAndTotalWith5PercentTip(overAllTotalWith5PercentTip);

            //25% Tip
            double tip25Percents = CalculateTip25Percents(totalWithTaxesWithoutTip);
            double overAllTotalWith25PercentTip = totalWithTaxesWithoutTip + tip25Percents;
            PrintTipAndTotalWith25PercentTip(overAllTotalWith25PercentTip);
        }

        static double GetTotalFromUser()
        {
            Console.Write("Total Before Taxes and Tip: $");
            double total = double.Parse(Console.ReadLine());
            return total;
        }

        static double CalculateTaxes(double totalWithoutTaxesAndTip)
        {
            return 0.2 * totalWithoutTaxesAndTip;
        }

        static void PrintTaxes(double taxes)
        {
            Console.WriteLine($"Tax(20%): ${taxes:F2}"); ;
        }

        static double CalculateTip5Percents(double totalWithTaxesWithoutTip)
        {
            return 0.05 * totalWithTaxesWithoutTip;
        }

        static void PrintTipAndTotalWith5PercentTip(double total)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Total Including Taxes With 5% Tip: ${total:F2}");
            Console.WriteLine();
        }

        static double CalculateTip25Percents(double totalWithTaxesWithoutTip)
        {
            return 0.25 * totalWithTaxesWithoutTip;
        }

        static void PrintTipAndTotalWith25PercentTip(double total)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Total Including Taxes With 25% Tip: ${total:F2}");
            Console.WriteLine();
        }
    }
}

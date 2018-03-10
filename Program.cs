using System;

namespace _00_Exam_Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            amountMoney = Math.Round(amountMoney, 2, MidpointRounding.AwayFromZero);
            sabrePrice = Math.Round(sabrePrice, 2, MidpointRounding.AwayFromZero);
            robePrice = Math.Round(robePrice, 2, MidpointRounding.AwayFromZero);
            beltPrice = Math.Round(beltPrice,2, MidpointRounding.AwayFromZero);
            int addStudentsSabre =(int) Math.Ceiling(students * 1.1);

            var beltDsic = 0;

            if (students%6==0)
            {
                beltDsic = students - (students / 6);
            }
            else if(students>6)
            {
                beltDsic =students-(students/6) ;
            }
            else
            {
                beltDsic = students;
            }

             

            double needeMoneySabre =  sabrePrice * addStudentsSabre;

            double neededMoneyRobes = (robePrice * students);
            double neededMoneyBelts = (beltPrice * beltDsic);  

            double allNeededMoney = (neededMoneyBelts + neededMoneyRobes + needeMoneySabre);
            if (allNeededMoney>amountMoney)
            {
                double moneyNeeded =  (allNeededMoney - amountMoney);
                moneyNeeded = Math.Round(moneyNeeded, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine($"Ivan Cho will need {moneyNeeded:F2}lv more.");
            }
            else
            {
                allNeededMoney = Math.Round(allNeededMoney, 2, MidpointRounding.AwayFromZero);

                Console.WriteLine($"The money is enough - it would cost {allNeededMoney:F2}lv.");

            }

        }
    }
}

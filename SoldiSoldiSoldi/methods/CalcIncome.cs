namespace SoldiSoldiSoldi.methods
{
    public static class CalcIncome
    {
        public static decimal IncomeSet()
        {
            bool convertRes = false;
            decimal income = 0;
            do
            {
                Console.WriteLine("\nInserisci il reddito annuale:");
                string? input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal convertInput) && convertInput >= 0)
                {
                    income = convertInput;
                    convertRes = true;
                }
                else
                {
                    Console.WriteLine($"\nValore inserito ({input}) non e' valido\n");
                }
            } while (!convertRes);
            return income;
        }
        public static decimal TaxCalc()
        {
            decimal income = Contribuente.Income;
            decimal toBePaid = Contribuente.ToBePaid;
            int T1 = 15000, T2 = 28000, T3 = 55000, T4 = 75000;

            //TRASHOLD_1
            decimal Trashold1 = income * 0.23m;
            decimal Trashold1Max = T1 * 0.23m;
            //TRASHOLD_2
            decimal Trashold2 = Trashold1Max + (income - T1) * 0.27m;
            decimal Trashold2Max = Trashold1Max + (T2 - T1) * 0.27m;
            //TRASHOLD_3
            decimal Trashold3 = Trashold2Max + (income - T2) * 0.38m;
            decimal Trashold3Max = Trashold2Max + (T3 - T2) * 0.38m;
            //TRASHOLD_4
            decimal Trashold4 = Trashold3Max + (income - T3) * 0.41m;
            decimal Trashold4Max = Trashold3Max + (T4 - T3) * 0.41m;
            //TRASHOLD_5
            decimal Trashold5 = Trashold4Max + (income - T4) * 0.43m;
            if (income <= T1)
            {
                toBePaid = Trashold1;
            }
            else if (income <= T2)
            {
                toBePaid = Trashold2;
            }
            else if (income <= T3)
            {
                toBePaid = Trashold3;
            }
            else if (income <= T4)
            {
                toBePaid = Trashold4;
            }
            else
            {
                toBePaid = Trashold5;
            }
            return toBePaid;
        }
    }
}
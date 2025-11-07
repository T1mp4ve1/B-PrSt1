namespace SoldiSoldiSoldi
{
    public static class Contribuente
    {
        //public string Name;
        //public string LastName;
        //public string Sex;
        //public string Birth;
        //public string CF;
        //public string Resident;
        public static decimal Income;

        public static void IncomeCalc()
        {
            Console.WriteLine("Inserisci tuo reddito annuale:");
            string? input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal convertInput))
            {
                Income = convertInput;
                //Console.WriteLine($"Il tuo reddito annuale: {Income}");
            }
        }
    }
}

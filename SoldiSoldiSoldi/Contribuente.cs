using SoldiSoldiSoldi.methods;
namespace SoldiSoldiSoldi
{
    public static class Contribuente
    {
        public static string? Name;
        public static string? LastName;
        public static string? Sex;
        public static DateOnly Birth;
        public static string? CF;
        public static string? Resident;
        public static decimal Income;
        public static decimal ToBePaid;

        //DATI CLIENTE
        public static void UserInfo()
        {
            Name = UserName.NameSet();
            LastName = UserLastName.LastNameSet();
            Sex = UserSex.SexSet();
            Birth = UserBirthDate.BirthSet();
            CF = UserCF.CFSet();
            Resident = UserResident.ResidentSet();

            //MODIFICA DATI
            bool confirmForm = false;
            do
            {
                Console.Clear();
                Console.WriteLine("\nDati del contribuente:");
                Console.WriteLine("=================================================\n");
                Console.WriteLine($"Contribuente: {Name} {LastName} ({Sex})");
                Console.WriteLine($"nato il: {Birth}");
                Console.WriteLine($"Residente in: {Resident}");
                Console.WriteLine($"Codice fiscale: {CF}");
                Console.WriteLine("\n=================================================\n");
                Console.WriteLine("Premi <1> per confermare, <2> per modificare i dati");
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        confirmForm = true;
                        break;
                    case "2":
                        ModifiedInfo.InfoToMod();
                        break;
                }
            } while (!confirmForm);

            //IMPOSTA
            Income = CalcIncome.IncomeSet();
            ToBePaid = CalcIncome.TaxCalc();
        }

        //FINAL
        public static void ShowResults()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine($"Reddito dichiarato: {Income}\r\n");
            Console.WriteLine($"IMPOSTA DA VERSARE: {ToBePaid}\r\n");
        }
    }
}

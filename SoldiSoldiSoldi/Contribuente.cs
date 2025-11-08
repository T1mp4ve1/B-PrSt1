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
        }

        //IMPOSTA
        public static void IncomeCalc()
        {
            bool convertRes = false;
            do
            {
                Console.WriteLine("\nInserisci tuo reddito annuale:");
                string? input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal convertInput) && convertInput >= 0)
                {
                    Income = convertInput;
                    convertRes = true;
                }
                else
                {
                    Console.WriteLine($"\nValore inserito ({input}) non e' valido\n");
                }
            } while (!convertRes);

            int T1 = 15000, T2 = 28000, T3 = 55000, T4 = 75000;

            //TRASHOLD_1
            decimal Trashold1 = Income * 0.23m;
            decimal Trashold1Max = T1 * 0.23m;
            //TRASHOLD_2
            decimal Trashold2 = Trashold1Max + (Income - T1) * 0.27m;
            decimal Trashold2Max = Trashold1Max + (T2 - T1) * 0.27m;
            //TRASHOLD_3
            decimal Trashold3 = Trashold2Max + (Income - T2) * 0.38m;
            decimal Trashold3Max = Trashold2Max + (T3 - T2) * 0.38m;
            //TRASHOLD_4
            decimal Trashold4 = Trashold3Max + (Income - T3) * 0.41m;
            decimal Trashold4Max = Trashold3Max + (T4 - T3) * 0.41m;
            //TRASHOLD_5
            decimal Trashold5 = Trashold4Max + (Income - T4) * 0.43m;
            if (Income <= T1)
            {
                ToBePaid = Trashold1;
            }
            else if (Income <= T2)
            {
                ToBePaid = Trashold2;
            }
            else if (Income <= T3)
            {
                ToBePaid = Trashold3;
            }
            else if (Income <= T4)
            {
                ToBePaid = Trashold4;
            }
            else
            {
                ToBePaid = Trashold5;
            }
        }
        //FINAL
        public static void ShowResults()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:\r\n");
            Console.WriteLine($"Contribuente: {Name} {LastName} ({Sex})\r\n");
            Console.WriteLine($"nato il: {Birth}\r\n");
            Console.WriteLine($"Residente in: {Resident}\r\n");
            Console.WriteLine($"Codice fiscale: {CF}\r\n");
            Console.WriteLine($"Reddito dichiarato: {Income}\r\n");
            Console.WriteLine($"IMPOSTA DA VERSARE: {ToBePaid}\r\n");
        }
    }
}

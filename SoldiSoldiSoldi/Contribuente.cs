namespace SoldiSoldiSoldi
{
    public static class Contribuente
    {
        public static string? Name;
        public static string? LastName;
        public static string? Sex;
        public static DateTime Birth;
        public static string? CF;
        public static string? Resident;
        public static decimal Income;
        public static decimal ToBePaid;

        //DATI CLIENTE
        public static void UserInfo()
        {
            //NOME
            Console.WriteLine("\nInserisci tuo nome:");
            Name = Console.ReadLine();
            //COGNOME
            Console.WriteLine("\nInserisci tuo cognome:");
            LastName = Console.ReadLine();
            //SESSO
            bool sexChoice = false;
            do
            {
                Console.WriteLine("\nSeleziona il tuo sesso:");
                Console.WriteLine("1 - Maschio");
                Console.WriteLine("2 - Femmina");
                Console.WriteLine("3 - Booh");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Sex = "M";
                        sexChoice = true;
                        break;
                    case "2":
                        Sex = "F";
                        sexChoice = true;
                        break;
                    case "3":
                        Sex = "X";
                        sexChoice = true;
                        break;
                    default:
                        Console.WriteLine("\nScelta non valida\n");
                        break;
                }
            } while (!sexChoice);
            //NASCITA
            bool BirthStatus = false;
            do
            {
                Console.WriteLine("\nInserisci la tua data di nascita in formato: gg/mm/aaaa");
                string? input = Console.ReadLine();

                if (DateTime.TryParseExact(input, "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out DateTime birthDate))
                {
                    Birth = birthDate;
                    BirthStatus = true;
                }
                else
                {
                    Console.WriteLine("\nDevi inserire una data valida");
                }
            } while (!BirthStatus);
            //CF
            bool CFStatus = false;
            do
            {
                Console.WriteLine("\nInserisci il tuo codice fiscale:");
                string? input = Console.ReadLine();
                CF = input;
                CFStatus = true;
            } while (!CFStatus);
            //RESIDENZA
            bool Residenttatus = false;
            do
            {
                Console.WriteLine("\nInserisci la citta di residenza:");
                string? input = Console.ReadLine();
                Resident = input;
                Residenttatus = true;
            } while (!Residenttatus);
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

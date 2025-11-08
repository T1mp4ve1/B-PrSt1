namespace SoldiSoldiSoldi.methods
{
    public static class UserSex
    {
        public static string SexSet()
        {
            bool sexChoice = false;
            string Sex = "";
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
            return Sex;
        }
    }
}

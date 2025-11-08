namespace SoldiSoldiSoldi.methods
{
    public static class ModifiedInfo
    {
        public static void InfoToMod()
        {
            Console.WriteLine("\nPremi il numere corrispondente al dato da modificare o premi 0 per uscire:");
            Console.WriteLine("=================================================\n");
            Console.WriteLine("1.Nome");
            Console.WriteLine("2.Cognome");
            Console.WriteLine("3.Sesso");
            Console.WriteLine("4.Data di nascita");
            Console.WriteLine("5.Residenza");
            Console.WriteLine("6.Codice fiscale");
            Console.WriteLine("0.Per uscire");
            Console.WriteLine("\n=================================================\n");

            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "0":
                    break;
                case "1":
                    Contribuente.Name = UserName.NameSet();
                    break;
                case "2":
                    Contribuente.LastName = UserLastName.LastNameSet();
                    break;
                case "3":
                    Contribuente.Sex = UserSex.SexSet();
                    break;
                case "4":
                    Contribuente.Birth = UserBirthDate.BirthSet();
                    break;
                case "5":
                    Contribuente.Resident = UserResident.ResidentSet();
                    break;
                case "6":
                    Contribuente.CF = UserCF.CFSet();
                    break;
                default:
                    Console.WriteLine("Premi un numero da 0 a 6...");
                    break;
            }
        }
    }
}

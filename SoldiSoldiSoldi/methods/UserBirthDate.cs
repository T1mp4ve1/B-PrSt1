namespace SoldiSoldiSoldi.methods
{
    public static class UserBirthDate
    {
        public static DateOnly BirthSet()
        {
            DateOnly Birth = DateOnly.MinValue;
            bool BirthStatus = false;
            do
            {
                Console.WriteLine("\nInserisci la tua data di nascita in formato: gg/mm/aaaa");
                string? input = Console.ReadLine();

                if (DateOnly.TryParseExact(input, "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out DateOnly birthDate))
                {
                    Birth = birthDate;
                    BirthStatus = true;
                }
                else
                {
                    Console.WriteLine("\nDevi inserire una data valida");
                }
            } while (!BirthStatus);
            return Birth;
        }
    }
}

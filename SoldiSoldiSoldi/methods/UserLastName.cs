namespace SoldiSoldiSoldi.methods
{
    public class UserLastName
    {
        public static string LastNameSet()
        {
            Console.WriteLine("\nInserisci tuo cognome:");
            string? input = Console.ReadLine();
            return input ?? string.Empty;
        }
    }
}

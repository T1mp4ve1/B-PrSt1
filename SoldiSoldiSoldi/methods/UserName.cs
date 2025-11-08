namespace SoldiSoldiSoldi.methods
{
    public static class UserName
    {
        public static string NameSet()
        {
            Console.WriteLine("\nInserisci tuo nome:");
            string? input = Console.ReadLine();
            return input ?? string.Empty;
        }
    }
}

namespace SoldiSoldiSoldi.methods
{
    public static class UserCF
    {
        public static string CFSet()
        {
            string CF = "";
            bool CFStatus = false;
            do
            {
                Console.WriteLine("\nInserisci il tuo codice fiscale:");
                string? input = Console.ReadLine();
                CF = input;
                CFStatus = true;
            } while (!CFStatus);
            return CF;
        }
    }
}

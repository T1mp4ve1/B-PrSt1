namespace SoldiSoldiSoldi.methods
{
    public static class UserResident
    {
        public static string ResidentSet()
        {
            string Resident = "";
            bool Residenttatus = false;
            do
            {
                Console.WriteLine("\nInserisci la citta di residenza:");
                string? input = Console.ReadLine();
                Resident = input;
                Residenttatus = true;
            } while (!Residenttatus);
            return Resident;
        }
    }
}

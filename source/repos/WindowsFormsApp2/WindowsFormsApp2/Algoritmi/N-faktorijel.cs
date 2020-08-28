namespace WindowsFormsApp2.Algoritmi
{
    public class N_faktorijel
    {
        public double IzracunatiFaktorijel(int broj)
        {
            if (broj == 1)
                return broj;
            else
                return broj * IzracunatiFaktorijel(broj - 1);
        }
    }
}

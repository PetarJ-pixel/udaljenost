namespace WindowsFormsApp2
{
    public class FibonacciNiz
    {
        static int Izracunaj(int n)
        {
            return (n < 2) ? n : Izracunaj(n - 1) + Izracunaj(n - 2);
        }
    }
}

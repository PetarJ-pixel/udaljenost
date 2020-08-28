namespace WindowsFormsApp2
{
    public class BrojDeljivSaTri
    {
        static bool check(string str)
        {
            int broj = str.Length;
            int sumaDigita = 0;

            for (int i = 0; i < broj; i++)
            {
                sumaDigita += (str[i] - '0');
            }

            return (sumaDigita % 3 == 0);
        }
    }
}

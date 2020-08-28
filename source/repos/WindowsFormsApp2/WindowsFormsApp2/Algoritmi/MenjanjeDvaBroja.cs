using System;

namespace WindowsFormsApp2
{
    public class MenjanjeDvaBroja
    {
        public void PromeniVrednosti()
        {
            int prvi = 5;
            int drugi = 10;
            Console.WriteLine("Pre promene prvi = " + prvi + "drugi =" + drugi);
            prvi = prvi * drugi;//50
            drugi = prvi / drugi;//50%10=5
            prvi = prvi / drugi;//10
            Console.WriteLine("Nakon promene prvi = " + prvi + "drugi=" + drugi);
        }
    }
}

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Hilmi");
            Console.WriteLine(isimler.Length);
            
            isimler.Add("Burak");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

            /**
             * MyList<int> sayilar = new MyList<int>(); 
             * sayilar.Add(5);
             * 
             * 
             * List<string> liste = new List<string>();
             * Console.WriteLine(liste.Count);
             * 
             * 
            **/

        }
    }
}

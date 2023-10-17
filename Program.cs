namespace Men
{

    internal class Program
    {
        struct Human
        {
            public string id;
            public string name;
            
        }

        static bool OnlyNum(string id)
        {
            int i = 1;
            while(i <= id.Length-1 && char.IsDigit(id[i]))
            {
                i++;
            }
            return i > id.Length-1;
        }

        static bool OnlyLetterAndSpace(string name)
        {
            int i = 1;
            while (i <= name.Length - 1 && (char.IsLetter(name[i]) || char.Equals(name[i],' ')))
            {
                i++;
            }
            return i > name.Length - 1;
        }

        static bool IsMan(string id)
        {
            return id[0] = '1'; 
        }

        static void Main(string[] args)
        {
            //Bemenet
            int peopleCount;

            //Kimenet
            int count;

            //Ellenorz
            string inputText;
            bool error;

            //Beolv
            do {
                Console.WriteLine("Hany melos van(ertelem szeruen szama van es nem letezik negativ szamu ember)");
                inputText = Console.ReadLine();
                error = !int.TryParse(inputText, out peopleCount);
                if (error)
                {
                    Console.WriteLine("Halj mar meg... szerinted ez egy letszam? ujra");
                }
            }while (error);

            //tombok deklaralas
            Human[] people = new Human[peopleCount+1];
            string[] men =new string[peopleCount+1];

            //tomb beolvas
            Human data = new Human();
            for (int i = 0; i <= peopleCount; i++)
            {
                do //szemelyi szam (id)
                {
                    Console.WriteLine("Add meg a(z) {0}. szemelyi szamot! (csak ezzel kezdodhet: 1, 2, 3, 4 - pl: 31234567890) ",i+1);
                    data.id = Console.ReadLine();
                    error = !(data.id.Length == 11) || !(data.id[0] == '1' ||  data.id[0] == '2' ||  data.id[0] == '3' || data.id[0] == '4') || !OnlyNum(data.id);
                    if (error)
                    {
                        Console.WriteLine("max 11 es ezzel kezdodik a szam: 1, 2, 3, 4 . hagyjuk. ujra");
                    }
                } while (error);
                do //nev
                {
                    Console.WriteLine("Add meg a(z) {0} nevet!", i+1);
                    data.name = Console.ReadLine();
                    error = !data.name.Contains(' ') || !OnlyLetterAndSpace(data.name);
                    if (error)
                    {
                        Console.WriteLine("Halj meg... szerinted ez egy nev? ujra");
                    }
                } while (error);
                people[i] = data;
            }

            //Feldolgozas

           

        }
    }
}
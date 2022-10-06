//List<Note> NOTE = new List<Note>();
//while (true)
//{
//    Console.Write("\tВЫБЕРИТЕ ДЕЙСТВИЕ\n\t1) Добавить человека\n\t2) Выести весь список\n\t3) Вывести всех до опр. даты\n\tВыбор: "); int choice = Convert.ToInt32(Console.ReadLine());

//    switch (choice)
//    {
//        case 1:  //добавить
//        {
//            Console.Write("Фамилия: ");            string? Surname = Console.ReadLine();
//            Console.Write("Имя: ");                string? Name = Console.ReadLine();
//            Console.Write("День рождения: ");      int Day = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Месяц рождения: ");     int Month = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Год рождения: ");       int Year = Convert.ToInt32(Console.ReadLine());

//            NOTE.Add(new Note(Surname, Name, Day, Month, Year));
//            break;
//        }
//        case 2:  //вывести весь список
//        {
//            for (int i = 0; i < NOTE.Count; i++)
//            {
//                Console.WriteLine(NOTE[i].ToString());
//            }
//            break;
//        }
//        case 3: //поиск по дате
//        {
//            Console.Write("День рождения: ");      int Day = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Месяц рождения: ");     int Month = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Год рождения: ");       int Year = Convert.ToInt32(Console.ReadLine());

//            NOTE[0].search(NOTE, Day, Month, Year);
//            break;
//        }
//    }
//}

//struct Note
//{
//    string? Surname;
//    string? Name;
//    string? Born;
//    int Day;
//    int Month;
//    int Year;

//    public Note(string? Surname, string? Name, int Day, int Month, int Year)
//    {
//        this.Surname = Surname;
//        this.Name = Name;
//        this.Day = Day;
//        this.Month = Month;
//        this.Year = Year;
//        this.Born = Day + "." + Month + "." + Year;
//    }
//    public void search(List<Note> NOTE, int Day, int Month, int Year) //поиск по дате
//    {
//        bool flag = false;

//        for (int i = 0; i < NOTE.Count; i++)
//        {
//            if (NOTE[i].Year < Year && NOTE[i].Month < Month && NOTE[i].Day < Day)
//            {
//                Console.WriteLine(NOTE[i].ToString());
//                flag = true;
//                continue;
//            }
//        }
//        if (!flag)
//        {
//            Console.WriteLine("Ошибка!!!");
//        }
//    }
//    public override string? ToString()
//    {
//        return "Фамилия и Имя: " + this.Surname + " " + this.Name + " | Дата Рождения: " + this.Born;
//    }
//}

////////////////////////////////// task 2 //////////////////////////////////

using ConsoleApp2;


int width, height;

Rectangle obj = new Rectangle();
Console.Write($"Площадь = {obj.Square()}\nПериметр = {obj.Perimeter()}");

obj.Deconstruct(out width, out height);
Console.Write($"\nШирина = {width}\nВысота = {height}");

Console.ReadKey();
Console.Clear();

/////////////////

int width1, height1;

Console.Write("Введите ширину: "); width1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту: "); height1 = Convert.ToInt32(Console.ReadLine());

Rectangle obj1 = new Rectangle(width1, height1);
Console.Write($"Площадь = {obj1.Square()}\nПериметр = {obj1.Perimeter()}");

obj1.Deconstruct(out width1, out height1);
Console.Write($"\nШирина = {width1}\nВысота = {height1}");
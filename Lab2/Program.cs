using System;

namespace Lab_2_1
{
    class PrintedEdition
    {
        public string Name;
        public double Price;

        public PrintedEdition(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void Print() { return; }
        public virtual double Calculate() { return 0; }
    }

    class Journal : PrintedEdition
    {
        public string Periodicity;
        public int EmployeesNumber;

        // Конструктор з параметрами
        public Journal(string name, double price, string periodicity, int employees_number) :
            base(name, price)
        {
            Periodicity = periodicity;
            EmployeesNumber = employees_number;
        }

        // Реалізація віртуальних методів
        public override void Print()
        {
            Console.WriteLine(
                $"Імʼя: {Name}, періодичність: {Periodicity}, кількість співробітників: {EmployeesNumber}");
        }

        public override double Calculate()
        {
            int[] employees = { EmployeesNumber, EmployeesNumber - 1, EmployeesNumber + 2 };
            double avgCount = (employees[0] + employees[1] + employees[2]) / 3.0;
            return avgCount;
        }

        // Власні методи
        public void PrintDetails(string periodicity)
        {
            Console.WriteLine(
                $"Назва: {Name}, Періодичність: {periodicity}, Кількість співробітників: {EmployeesNumber}");
        }
    }

    class Book : PrintedEdition
    {
        public string Author;
        public int Circulation;

        public Book(string name, double price, string author, int circulation) : base(name, price)
        {
            Author = author;
            Circulation = circulation;
        }

        // Реалізація віртуальних методів
        public override void Print()
        {
            Console.WriteLine($"Книга: {Name}, Автор: {Author}, Ціна: {Price}, Тираж: {Circulation}");
        }

        // Власні методи
        public void PrintDetails(string name, string author)
        {
            Console.WriteLine($"Автор: {author}, Назва: {name}, Ціна: {Price}, Тираж: {Circulation}");
        }
    }
}

namespace Lab_2_2
{
    abstract class PrintedEdition
    {
        protected string Name;
        protected double Price;

        public PrintedEdition(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
    
    class Journal : PrintedEdition
    {
        public string Periodicity;
        public int EmployeesNumber;

        // Конструктор з параметрами
        public Journal(string name, double price, string periodicity, int employees_number) :
            base(name, price)
        {
            Periodicity = periodicity;
            EmployeesNumber = employees_number;
        }

        // Власні методи
        public void Print()
        {
            Console.WriteLine(
                $"Імʼя: {Name}, періодичність: {Periodicity}, кількість співробітників: {EmployeesNumber}");
        }
        public double Calculate()
        {
            int[] employees = { EmployeesNumber, EmployeesNumber - 1, EmployeesNumber + 2 };
            double avgCount = (employees[0] + employees[1] + employees[2]) / 3.0;
            return avgCount;
        }
    }
    
    class Book : PrintedEdition
    {
        public string Author;
        public int Circulation;

        public Book(string name, double price, string author, int circulation) : base(name, price)
        {
            Author = author;
            Circulation = circulation;
        }

        // Власні методи
        public void Print()
        {
            Console.WriteLine($"Книга: {Name}, Автор: {Author}, Ціна: {Price}, Тираж: {Circulation}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Перша реалізація
        Lab_2_1.Journal journal = new Lab_2_1.Journal("Наука і Життя", 5.99, "Щомісяця", 10);
        Lab_2_1.Book book = new Lab_2_1.Book("1984", 12.99, "Джордж Оруэлл", 50);

        journal.Print();
        journal.PrintDetails("Щомісяця");
        double periodicity = journal.Calculate();
        Console.WriteLine($"Середня кількість співробітників за 3 місяці: {periodicity}");

        book.Print();
        book.PrintDetails("Some book", "Some Author");
        
        // Друга реалізація
        Lab_2_2.Journal journal2 = new Lab_2_2.Journal("Наука і Життя", 5.99, "Щомісяця", 10);
        Lab_2_2.Book book2 = new Lab_2_2.Book("1984", 12.99, "Джордж Оруэлл", 50);

        journal2.Print();
        double periodicity2 = journal2.Calculate();
        Console.WriteLine($"Середня кількість співробітників за 3 місяці: {periodicity2}");

        book.Print();
    }
}
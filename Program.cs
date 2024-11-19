namespace ConsoleApp17
{
    using System;

    public class Дерево : IComparable<Дерево>
    {
        public string Порода { get; set; }
        public double Ціна { get; set; }

        public Дерево(string порода, double ціна)
        {
            Порода = порода;
            Ціна = ціна;
        }

        // Реалізація методу CompareTo для порівняння об'єктів за ціною
        public int CompareTo(Дерево іншеДерево)
        {
            if (іншеДерево == null)
                return 1; // Поточний об'єкт вважається більшим, якщо інше дерево дорівнює null

            return Ціна.CompareTo(іншеДерево.Ціна);
        }

        public override string ToString()
        {
            return $"Порода: {Порода}, Ціна: {Ціна} грн";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Створення масиву об'єктів класу Дерево
            Дерево[] дерева = {
            new Дерево("Дуб", 500),
            new Дерево("Береза", 300),
            new Дерево("Сосна", 400),
            new Дерево("Ялина", 350)
        };

            // Сортування масиву за ціною
            Array.Sort(дерева);

            // Виведення відсортованого масиву
            Console.WriteLine("Відсортовані дерева за ціною:");
            foreach (var дерево in дерева)
            {
                Console.WriteLine(дерево);
            }
        }
    }

}

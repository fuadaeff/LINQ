using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public bool IsActive { get; set; }
    }

    class Score
    {
        public string StudentName { get; set; }
        public int Value { get; set; }
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var oddNumbers = numbers.Where(n => n % 2 != 0);

        List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
        var nameLengths = names.Select(name => name.Length);

        List<Product> products = new List<Product>
        {
            new Product { Name = "Apple", Price = 1500 },
            new Product { Name = "Banana", Price = 800 },
            new Product { Name = "Orange", Price = 1200 }
        };
        var top3Products = products.OrderBy(p => p.Name).Take(3);

        var distinctNames = products.Select(p => p.Name).Distinct();

        List<Student> students = new List<Student>
        {
            new Student { Name = "John", Group = "A" },
            new Student { Name = "Alice", Group = "B" },
            new Student { Name = "Bob", Group = "A" }
        };
        var groupedStudents = students.GroupBy(s => s.Group).Select(g => new { Group = g.Key, Students = g.Select(s => s.Name) });

        var mostExpensiveProduct = products.OrderByDescending(p => p.Price).FirstOrDefault();

        var newStudentObjects = students.Select(s => new { s.Name, s.Group });

        var avgPrice = products.Where(p => p.Price > 1000).Average(p => p.Price);

        bool allActive = students.All(s => s.IsActive);
        bool anyActive = students.Any(s => s.IsActive);

        List<Score> scores = new List<Score>
        {
            new Score { StudentName = "John", Value = 85 },
            new Score { StudentName = "Alice", Value = 90 }
        };
        var joinedData = students.Join(scores, s => s.Name, sc => sc.StudentName, (s, sc) => new { s.Name, sc.Value });
    }
}
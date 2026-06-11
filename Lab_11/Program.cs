using System.Collections.Generic;
using System.Linq;
//Задание 11.51
// class Program
// {
//     static void Main()
//     {
//         double[] array = { -5.5, 0, 3.2, -1, 0, 4.5 };

//         double a1 = array[0]; // Элемент с номером 0 (можно задать вручную)
//         double a = 1;
//         double b = 2;
//         double c = 3;

//         var resultA = array.Select(x =>
//             x < 0 ? x + a1 :
//             x == 0 ? x - b :
//             x
//         ).ToArray();

//         Console.WriteLine("Вариант А: " + string.Join(", ", resultA));

//         var resultB = array.Select(x =>
//             x > 0 ? x - a :
//             x < 0 ? x - b :
//             x + c
//         ).ToArray();

//         Console.WriteLine("Вариант Б: " + string.Join(", ", resultB));
//     }
// }
//Задание 13.36
public class Student
{
    public string Surname { get; set; }
    public List<int> Grades { get; set; }
    public int TotalScore => Grades.Sum();
}

public class Program
{
    public static void Main()
    {
        List<Student> classStudents = new List<Student>
        {
            new Student { Surname = "Иванов", Grades = new List<int> { 5, 4, 5, 5 } },
            new Student { Surname = "Смирнов", Grades = new List<int> { 5, 5, 5, 5 } },
            new Student { Surname = "Кузнецов", Grades = new List<int> { 3, 4, 4, 3 } },
        };

        Student topStudent = classStudents
            .OrderByDescending(s => s.TotalScore)
            .FirstOrDefault();

        if (topStudent != null)
        {
            Console.WriteLine($"Ученик с максимальной суммой оценок: {topStudent.Surname} (Сумма: {topStudent.TotalScore})");
        }
        else
        {
            Console.WriteLine("Список учеников пуст.");
        }
    }
}

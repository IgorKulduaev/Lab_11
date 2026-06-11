using System.Collections.Generic;
using System.Linq;
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

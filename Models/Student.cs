namespace ConsoleApp5.Models;

public class Student : ICheck
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Gpa { get; set; }

    public Student(string name, int id, double gpa)
    {
        Name = name;
        Id = id;
        Gpa = gpa;
    }


    public void CheckGrade(params int[] grades)
    {  
        double count = 0;
        double sum = 0;
        foreach (double grade in grades)
        {
            sum += grade;
            count++;
            Gpa /= sum;
            

        }
            if (Gpa > 80)
            {
                Console.WriteLine("God academic points");
            }
            if (Gpa < 80)
            {
                Console.WriteLine("Bad academic points");
            }
    }

   
}

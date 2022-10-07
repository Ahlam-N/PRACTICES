// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<Students> ls = new List<Students>
{
    1,2,3,4,5
};
var QuerySyntax = from obj in ls
                  where obj > 2
                  select obj;
foreach (int item in QuerySyntax)
{
    Console.WriteLine(item);
}




public class student
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string Gender { get; set; }
     public static List<student > getallstudent()
    {
        List<student> ls = new List<student>();

        student student1 = new student
        {
            Id = 1,
            Name = "Ahlam",
            Gender = "F"

        };
        ls.Add(student1);

        student student2 = new student
        {
            Id = 2,
            Name = "Sumeya",
            Gender = "F"

        };

        ls.Add(student2);
        return ls;
    }
}
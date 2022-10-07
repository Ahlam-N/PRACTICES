// See https://aka.ms/new-console-template for more information
public class mainn
{
    static void Main(String[] args)
    {
        using(var crx=new StudentContext())
        {
            Student std = new Student()
            {
                name = "Ahlam";
            }crx.Students.Add(std);
        crx.SaveChanges();

        }
    }
}


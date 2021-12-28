namespace Clase3MVC.Models;

public class NomyApe
{
    public NomyApe(int Id, string name, string surname )
    {
        Id = id; 
        Name = name;
        Surname = surname;
    }

    public int id { get; set; }
    public string Name { get; }
    public string Surname { get; }
}
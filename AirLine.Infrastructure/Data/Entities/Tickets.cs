using System.ComponentModel.DataAnnotations;

public class Tickets
{
    [Key]
    public int Sit { get; set; }
    public string FullName { get; set; }
    public string Origin { get; set; }   
    public string Destination { get; set; }
    public DateTime FlyTime { get; set; }
    public decimal Price { get; set; }
    public string PlainModel { get; set; }
    public bool isReturned { get; set; }
}
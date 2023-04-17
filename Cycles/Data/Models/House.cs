namespace Cycles.Data.Models;

public class House
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int PropertyId { get; set; }

    public Property? Property { get; set; }
    public ICollection<Car> Houses { get; set; } = new List<Car>();
}

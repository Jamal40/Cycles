namespace Cycles.Data.Models;

public class Property
{
    public int Id { get; set; }
    public Guid Identifier { get; set; }

    public Car? Car { get; set; }
    public House? House { get; set; }
}

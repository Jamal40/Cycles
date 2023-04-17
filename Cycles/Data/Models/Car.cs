using System.ComponentModel.DataAnnotations.Schema;

namespace Cycles.Data.Models;

public class Car
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int PropertyId { get; set; }

    public Property? Property { get; set; }
    public ICollection<House> Houses { get; set; } = new List<House>();
}



namespace Bugs.Models;

public class Purchaser
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public Address Address { get; set; } = new Address();
    public virtual List<Contract> Contracts { get; set; } = new List<Contract>();
}
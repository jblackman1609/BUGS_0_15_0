
namespace Bugs.Models;

public class Contract
{
    public int Id { get; set; }
    public string BondType { get; set; } = string.Empty;
    public string PropertyDescription { get; set; } = string.Empty;
    public Address Address { get; set; } = new Address();
    public string ContractPrice { get; set; } = string.Empty;
    public decimal RenewalFee { get; set; }
    public decimal TransferFee { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime ThroughDate { get; set; }
    public int PurchaserId { get; set; }
    public Purchaser Purchaser { get; set; } = new Purchaser();
}

namespace Bugs.Data;

public class Repository
{
    public PurchaserRepository Purchasers { get; }
    public ContractRepository Contracts { get; }

    public Repository()
    {
        Purchasers = new PurchaserRepository();
        Contracts = new ContractRepository();
    }
}
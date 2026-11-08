
using Bugs.Models;

namespace Bugs.Data;

public class ContractRepository
{
    private readonly BugsContext _context;

    public ContractRepository() => _context = new BugsContext();

    public void AddContract(Contract contract)
    {
        _context.Contracts.Add(contract);
        _context.SaveChanges();
    }

    public void UpdateContract(Contract contract)
    {
        _context.Contracts.Update(contract);
        _context.SaveChanges();
    }

    public void DeleteContract(Contract contract)
    {
        _context.Contracts.Remove(contract);
        _context.SaveChanges();
    }

    public Contract GetContract(int id)
    {
        return _context.Contracts.Find(id) ?? throw new InvalidOperationException("Contract not found");
    }

    public List<Contract> GetAllContracts()
    {
        return _context.Contracts.ToList();
    }
}
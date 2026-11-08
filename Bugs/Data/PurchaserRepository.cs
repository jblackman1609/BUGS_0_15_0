
using Bugs.Models;

namespace Bugs.Data;

public class PurchaserRepository
{
    private readonly BugsContext _context;

    public PurchaserRepository() => _context = new BugsContext();

    public List<Purchaser> GetAllPurchasers()
    {
        return _context.Purchasers.ToList();
    }

    public Purchaser GetPurchaser(int id)
    {
        return _context.Purchasers.FirstOrDefault(p => p.Id == id) ?? throw new InvalidOperationException("Purchaser not found");
    }

    public Purchaser GetPurchaser(string name)
    {
        return _context.Purchasers.FirstOrDefault(p => p.Name == name) ?? throw new InvalidOperationException("Purchaser not found");
    }

    public void AddPurchaser(Purchaser purchaser)
    {
        _context.Purchasers.Add(purchaser);
        _context.SaveChanges();
    }

    public void UpdatePurchaser(Purchaser purchaser)
    {
        _context.Purchasers.Update(purchaser);
        _context.SaveChanges();
    }

    public void DeletePurchaser(int id)
    {
        var purchaser = GetPurchaser(id);
        if (purchaser != null)
        {
            _context.Purchasers.Remove(purchaser);
            _context.SaveChanges();
        }
    }
}
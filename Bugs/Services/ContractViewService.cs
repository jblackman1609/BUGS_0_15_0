
using Bugs.Data;
using Bugs.Models;

namespace Bugs.services;

public class ContractViewService
{
    private readonly Repository _repository;

    public ContractViewService() => _repository = new Repository();

    public List<Contract> GetContractsView()
    {
        return _repository.Contracts.GetAllContracts();
    }

    public void AddContract(Contract contract)
    {
        Purchaser purchaser = _repository.Purchasers.GetPurchaser(contract.Purchaser.Name);

        if (purchaser == null)
        {
            _repository.Purchasers.AddPurchaser(contract.Purchaser);
        }
        
        _repository.Contracts.AddContract(contract);
    }

    /*public ContractViewModel GetAddNewContractView()
    {
        return new ContractViewModel
        {
            
        };
    }*/
}

namespace Bugs.services;

public class Service
{
    public ContractViewService ContractView { get; }
    //public ExportContractService ExportContract { get; }

    public Service()
    {
        ContractView = new ContractViewService();
        //ExportContract = new ExportContractService();
    }
}
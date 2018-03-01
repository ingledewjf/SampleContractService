namespace ContractService
{
    using Models;

    public interface IContractRepository
    {
        void Add(Contract contract);

        Contract Get(string contractNumber);

        void DeleteContract(string contractNumber);

        void DeleteContractAllocation(string contractNumber, string allocationNumber);

        void DeleteContractDeliverable(string contractNumber, string allocationNumber, int deliverableCode);

        decimal GetMaximumValue(string contractNumber);

        decimal GetProfileValue(string contractNumber);
    }
}

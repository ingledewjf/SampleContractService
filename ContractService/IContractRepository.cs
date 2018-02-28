namespace ContractService
{
    using Models;

    public interface IContractRepository
    {
        void Add(Contract contract);

        Contract Get(string contractNumber);

        decimal GetMaximumValue(string contractNumber);

        decimal GetProfileValue(string contractNumber);
    }
}

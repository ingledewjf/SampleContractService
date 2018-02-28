namespace ContractService
{
    using System.Collections.Generic;
    using Models;

    public class ContractRepository : IContractRepository
    {
        public void Add(Contract contract) {}

        public Contract Get(string contractNumber) { throw new NotImplementedException(); }

        public decimal GetMaximumValue(string contractNumber) { throw new NotImplementedException(); }

        public decimal GetProfileValue(string contractNumber) { throw new NotImplementedException(); }
    }
}
namespace ContractService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class ContractRepository : IContractRepository
    {
        private readonly List<Contract> _contractCache;

        public ContractRepository()
        {
            _contractCache = new List<Contract>();
        }

        public void Add(Contract contract) 
        {
            _contractCache.Add(contract);
        }

        public void DeleteContract(string contractNumber) 
        {

        }

        public void DeleteContractAllocation(string contractNumber, string allocationReference) 
        {

        }

        public void DeleteContractDeliverable(string contractNumber, string allocationNumber, int deliverableCode) 
        {

        }

        public Contract Get(string contractNumber) 
        { 
            return _contractCache.SingleOrDefault(c => c.ContractNumber == contractNumber);
        }

        public decimal GetMaximumValue(string contractNumber) 
        {
            return _contractCache.SingleOrDefault(c => c.ContractNumber == contractNumber)
                ?.Allocations.Sum(a => a.Deliverables.Sum(d => d.Value))
                ?? 0m;
        }

        public decimal GetProfileValue(string contractNumber) 
        {
            return _contractCache.SingleOrDefault(c => c.ContractNumber == contractNumber)
                ?.Allocations
                    .Where(a => a.AllocType == AllocationType.PayOnProfile)
                    .Sum(a => a.Deliverables.Sum(d => d.Value))
                ?? 0m;
        }
    }
}
namespace ContractService.Models
{
    using System.Collections.Generic;

    public class Contract
    {
        public string ContractNumber {get; set;}
        
        public List<ContractAllocation> Allocations {get;set;}
    }
}
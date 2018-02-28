namespace ContractService.Models
{
    public class ContractAllocation
    {
        public string AllocationReference {get;set;}
        public AllocationType AllocType {get;set;}
        public List<Deliverable> Deliverables {get;set;}
    }
}
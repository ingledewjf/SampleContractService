namespace ContractService.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ContractService;
    using ContractService.Models;

    [TestClass]
    public class ContractRepositoryTests
    {
        [TestMethod]
        public void ContractService_Add_ShouldAddASingleContract()
        {
            // arrange
            Contract testContract = new Contract 
            {
                ContractNumber = "ABC-123",
                Allocations = new List<ContractAllocation>()
            };

            var repository = new ContractRepository();

            // act
            repository.Add(testContract);

            // assert
            var actual = repository.Get("ABC-123");

            Assert.IsNotNull(actual);
            Assert.IsNotNull(actual.Allocations);
            Assert.IsFalse(actual.Allocations.Any());
            Assert.AreEqual("ABC-123", actual.ContractNumber);
        }

        [TestMethod]
        public void ContractService_Add_ShouldAddASingleContractMultipleTimes()
        {
            // arrange
            Contract testContract0 = new Contract 
            {
                ContractNumber = "ABC-123",
                Allocations = new List<ContractAllocation>()
            };

            Contract testContract1 = new Contract 
            {
                ContractNumber = "ABC-234",
                Allocations = new List<ContractAllocation>()
            };

            Contract testContract2 = new Contract 
            {
                ContractNumber = "ABC-345",
                Allocations = new List<ContractAllocation> 
                {
                    new ContractAllocation 
                    {
                        AllocationReference = "Alloc-1",
                        AllocType = AllocationType.PayOnActual,
                        Deliverables = new List<Deliverable>()
                    }
                }
            };

            Contract testContract3 = new Contract 
            {
                ContractNumber = "ABC-456",
                Allocations = new List<ContractAllocation> 
                {
                    new ContractAllocation 
                    {
                        AllocationReference = "Alloc-1",
                        AllocType = AllocationType.PayOnProfile,
                        Deliverables = new List<Deliverable> 
                        {
                            new Deliverable
                            {
                                Id = 1,
                                Value = 0m
                            }
                        }
                    }
                }
            };

            var repository = new ContractRepository();

            // act
            repository.Add(testContract0);
            repository.Add(testContract1);
            repository.Add(testContract2);
            repository.Add(testContract3);

            // assert
            var actual0 = repository.Get("ABC-123");
            var actual1 = repository.Get("ABC-234");
            var actual2 = repository.Get("ABC-345");
            var actual3 = repository.Get("ABC-456");

            Assert.IsNotNull(actual0);
            Assert.IsNotNull(actual0.Allocations);
            Assert.IsFalse(actual0.Allocations.Any());
            Assert.AreEqual("ABC-123", actual0.ContractNumber);

            Assert.IsNotNull(actual1);
            Assert.IsNotNull(actual1.Allocations);
            Assert.IsFalse(actual1.Allocations.Any());
            Assert.AreEqual("ABC-234", actual1.ContractNumber);

            Assert.IsNotNull(actual2);
            Assert.IsNotNull(actual2.Allocations);
            Assert.IsTrue(actual2.Allocations.Any());
            Assert.AreEqual("ABC-345", actual2.ContractNumber);

            Assert.IsNotNull(actual3);
            Assert.IsNotNull(actual3.Allocations);
            Assert.IsTrue(actual3.Allocations.Any());
            Assert.AreEqual("ABC-456", actual0.ContractNumber);
        }

        [TestMethod]
        public void ContractRepository_Get_ShouldReturnNullIfNoContractFound() 
        {
            // arrange
            var contractRepository = new ContractRepository();

            // act
            var actual = contractRepository.Get("ABCD-321");

            // assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void ContractRepository_GetTotalValue_ShouldGetTotalValueForASingleContract() 
        {
            // implement this test!

            // arrange

            // act

            //assert
            Assert.Fail();
        }

        [TestMethod]
        public void ContractRepository_GetProfileValue_ShouldGetTotalProfileValueForASingleContract()
        {
            // implement this test!

            // arrange

            // act

            //assert
            Assert.Fail();
        }
    }
}

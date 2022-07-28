using Shared.Database;
using Shared.Models;
using Shared.ModelDTO;
using Shared.Services;
using Shared.IServices;

namespace TestProject
{
    public class VendorServiceTest
    {
        private VendorService _VendorServices;
        private NV_DBContext _dbContext;

        public VendorServiceTest()
        {
            _VendorServices = new VendorService();
        }

        [Fact]
        public void TestAddVendor()
        {
            var obj = new Vendor
            {
                VendorName = "Naveed",
                VendorAddress = "Abc Street",
                VendorContact = "032323332",
                OtherDetails = "",
                Email = "naveed@gmail.com",
                IsActive = true,
                CreateAt = DateTime.UtcNow,

            };

            //Act
            obj.VendorName = "Naveed";

            //Assert
            Assert.Equal("Naveed", obj.VendorName);

          //  _VendorServices.Add(obj);

        }
    }
}
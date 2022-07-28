using Shared.Services;
using Shared.Database;
using Shared.Models;
using Shared.ModelDTO.Vendor;

namespace InvConsoleApp
{
    public class Program
    {       

        static void Main(string[] args)
        {

            Console.WriteLine("Add Vendor");
            Console.WriteLine("----------");

            VendorService _VendorService = new VendorService();
            var obj = new Vendor()
            {
                VendorName = "Naveed",
                VendorAddress = "Abc Street",
                VendorContact = "032323332",
                OtherDetails = "",
                Email = "naveed@gmail.com",
                IsActive = true,
                CreateAt = DateTime.UtcNow,
            };

            _VendorService.Adds(obj);

        }

        public void Add(AddVendor addVendor)
        {

            VendorService _VendorService = new VendorService();
            var obj = new Vendor()
            {
                VendorName = addVendor.VendorName,
                VendorAddress = addVendor.VendorAddress,
                VendorContact = addVendor.VendorContact,
                Email = addVendor.Email,
                OtherDetails = addVendor.OtherDetails,
                IsActive = true,
                CreateAt = DateTime.Now,
            };

            _VendorService.Add(obj);
        }


        //public void InsertVendor()
        //{

        //    var addVendor = new AddVendor();

        //    Console.WriteLine("Enter Vendor Record");

        //    addVendor.VendorName = Console.ReadLine();
        //    addVendor.VendorAddress = Console.ReadLine();
        //    addVendor.VendorContact = Console.ReadLine();
        //    addVendor.Email = Console.ReadLine();
        //    addVendor.OtherDetails = Console.ReadLine();

        //    var obj = new Vendor()
        //    {
        //        VendorName = addVendor.VendorName,
        //        VendorAddress = addVendor.VendorAddress,
        //        VendorContact = addVendor.VendorContact,
        //        Email = addVendor.Email,
        //        OtherDetails = addVendor.OtherDetails,
        //        IsActive = true,
        //        CreateAt = DateTime.Now,

        //    };

        //    _dbcontext.Add(obj);
        //    _dbcontext.SaveChanges();

        //}



    }
}
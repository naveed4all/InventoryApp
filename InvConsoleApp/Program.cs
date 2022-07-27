using InventoryApp.Database;
using InventoryApp.Models;
using Shared.ModelDTO;


namespace InvConsoleApp
{
    public class Program
    {
        public Program(INV_DBContext context)
        {
             // this._dbcontext = context;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Add Vendor");
            Console.WriteLine("----------");
                        

          //  InsertVendor();
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
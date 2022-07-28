using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.ModelDTO;
using Shared.IServices;
using Microsoft.EntityFrameworkCore;
using Shared.Database;
using Shared.Models;

namespace Shared.Services
{
    public class VendorService : IServices<Vendor>
    {

        private NV_DBContext _dbcontext;

        public VendorService()
        {
           
        }
        public VendorService(NV_DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Vendor> Add(Vendor vendor)
        {
            var result = await _dbcontext.Vendors.AddAsync(vendor);
            await _dbcontext.SaveChangesAsync();
            return vendor;
        }

        public void Adds(Vendor vendor)
        {
            var result = _dbcontext.Vendors.Add(vendor);
            _dbcontext.SaveChanges();            
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Vendor> Get(Func<Vendor, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vendor>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Vendor> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Vendor> Update(Vendor vendor)
        {
            var result = await _dbcontext.Vendors.FirstOrDefaultAsync(e => e.VendorId == vendor.VendorId);

            if (result != null)
            {
                result.VendorName = vendor.VendorName;
                result.VendorAddress = vendor.VendorAddress;
                result.Email = vendor.Email;
                result.VendorContact = vendor.VendorContact;
                result.OtherDetails = vendor.OtherDetails;
                result.ModifiedBy = vendor.ModifiedBy;
                result.ModifiedDate = vendor.ModifiedDate;

                await _dbcontext.SaveChangesAsync();

                return result;
            }

            return null;
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

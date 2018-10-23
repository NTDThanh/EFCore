using EFCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCore.Data.DataAccess.Repository
{
    public class AddressRepository
    {
        public List<Address> EagerLoadingWithThen()
        {
            using (var db = new AddressContext())
            {
                return db.Address
                    .Include(x => x.City)
                    .ThenInclude(x => x.County)
                    .ToList();
            }

        }

        //public List<Address> EagerLoadingWithInclude()
        //{
        //    using (var db = new AddressContext())
        //    {
        //        return db.Address
        //            .Include(x => x.City)
        //            .Include(x => x.County)
        //            .ToList();
        //    }
        //}
    }
}

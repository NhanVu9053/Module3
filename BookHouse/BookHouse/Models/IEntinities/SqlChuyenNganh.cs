using BookHouse.Models.EF;
using BookHouse.Models.Entinities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.IEntinities
{
    public class SqlChuyenNganh : IChuyenNganh
    {
        private readonly BookHouseDbContext context;

        public SqlChuyenNganh(BookHouseDbContext context)
        {
            this.context = context;
        }
        public ChuyenNganh Create(ChuyenNganh chuyenNganh)
        {
            context.ChuyenNganhs.Add(chuyenNganh);
            context.SaveChanges();
            return chuyenNganh;
          
        }

        public bool Delete(int id)
        {
            var delChuyenNganh = context.ChuyenNganhs.Find(id);
            if(delChuyenNganh != null)
            {
                context.ChuyenNganhs.Remove(delChuyenNganh);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public ChuyenNganh Edit(ChuyenNganh chuyenNganh)
        {
            var editChuyenNganh = context.ChuyenNganhs.Attach(chuyenNganh);
            editChuyenNganh.State = EntityState.Modified;
            context.SaveChanges();
            return chuyenNganh;

        }

        public ChuyenNganh Get(int id)
        {
            return context.ChuyenNganhs.Find(id);
        }

        public IEnumerable<ChuyenNganh> Gets()
        {
            return context.ChuyenNganhs;
        }
    }
}

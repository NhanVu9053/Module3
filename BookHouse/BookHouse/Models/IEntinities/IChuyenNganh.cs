using BookHouse.Models.Entinities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.IEntinities
{
  public  interface IChuyenNganh
    {
        IEnumerable<ChuyenNganh> Gets();
        ChuyenNganh Get(int id);
        ChuyenNganh Create(ChuyenNganh chuyenNganh);
        ChuyenNganh Edit(ChuyenNganh chuyenNganh);
        bool Delete(int id);

    }
}

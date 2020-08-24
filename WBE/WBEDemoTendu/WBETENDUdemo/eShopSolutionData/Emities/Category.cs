using eShopSolutionData.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolutionData.Emities
{
   public class Category
    {
        public int id { get; set; }
        public int SortOrder { get; set; }
        public bool IsSoOnHome { get; set; }
        public int? parentID { get; set; }
        public Status Status { get; set; }


    }
}

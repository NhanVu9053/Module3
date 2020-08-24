using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.ViewModels
{
    public class CreateViewRoleModel
    {
        [Required]
        public int RoleName { get; set; }
    }
}

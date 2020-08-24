using Microsoft.AspNetCore.Http;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.ViewModels
{
    public class HomeEditViewModel : HomeCreateViewModel
    {
        public int Id { get; set; }
        public string AvatarPath { get; set; }
       
    }
}

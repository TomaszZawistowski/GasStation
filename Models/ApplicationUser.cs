﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation.Models
{
    public class ApplicationUser : IdentityUser
    {
       public string Name { get; set; }
       public string Surname { get; set; }
       public string PESEL { get; set; }
       public List<Transaction> Transactions { get; set; }
    }
}

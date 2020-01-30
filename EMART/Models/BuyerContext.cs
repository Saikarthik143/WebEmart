﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMART.Models
{
    public class BuyerContext:DbContext
    {
        public BuyerContext(DbContextOptions<BuyerContext> options) : base(options) { }
        public DbSet<Buyer> buyers { get; set; }
    }
}

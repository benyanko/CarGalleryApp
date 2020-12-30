using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarGalleryApp.Models;

    public class data : DbContext
    {
        public data (DbContextOptions<data> options)
            : base(options)
        {
        }

        public DbSet<CarGalleryApp.Models.Car> Car { get; set; }
    }

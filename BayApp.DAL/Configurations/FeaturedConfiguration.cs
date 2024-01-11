using BayApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayApp.DAL.Configurations
{
    public class FeaturedConfiguration : IEntityTypeConfiguration<Featured>
    {
        public void Configure(EntityTypeBuilder<Featured> builder) 
        {
            builder.Property(f=>f.Title).IsRequired().HasMaxLength(70);
            builder.Property(f=>f.Description).IsRequired();
        }
    }
    
    
}

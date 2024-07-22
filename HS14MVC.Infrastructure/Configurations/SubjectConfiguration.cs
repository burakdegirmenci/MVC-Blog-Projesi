using HS14MVC.Domain.Core.BaseEntityConfigurations;
using HS14MVC.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Infrastructure.Configurations
{
    public class SubjectConfiguration: AuditableEntityConfiguration<Subject>
    {
        public override void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.Property(s=>s.Name).IsRequired().HasMaxLength(128);
            base.Configure(builder);
        }
    }
}

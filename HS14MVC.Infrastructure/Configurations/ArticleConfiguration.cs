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
    public class ArticleConfiguration: AuditableEntityConfiguration<Article>
    {
        public override void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(a=>a.Title).IsRequired().HasMaxLength(128);
            builder.Property(a=>a.Content).IsRequired();
            builder.Property(a=>a.Image).IsRequired(false);          

            base.Configure(builder);
        }
    }
}

using HS14MVC.Domain.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Domain.Entities
{
    public class Subject: AuditableEntity
    {
        public string Name { get; set; }


        // Nav Prop
        public virtual IEnumerable<Article> Articles { get; set; }
    }
}

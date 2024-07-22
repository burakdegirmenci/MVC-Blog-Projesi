using HS14MVC.Domain.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Domain.Entities
{
    public class Author: BaseUser
    {

        // Nav Prop
        public virtual IEnumerable<Article>Articles { get; set; }
    }
}

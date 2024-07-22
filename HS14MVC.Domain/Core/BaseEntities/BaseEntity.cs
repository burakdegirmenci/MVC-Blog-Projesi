using HS14MVC.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Domain.Core.BaseEntities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreadtedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public Status Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Domain.Utilities.Interfaces
{
    public interface IResult
    {
        public bool IsSuccess { get; }
        public string Messages { get; }
    }
}

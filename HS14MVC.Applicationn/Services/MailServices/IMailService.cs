using HS14MVC.Applicationn.DTOs.MailDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Applicationn.Services.MailServices
{
    public interface IMailService
    {
        Task SendMailAsync(SendMailDTO sendMailDTO);
    }
}

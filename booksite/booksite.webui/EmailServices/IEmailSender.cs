using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace booksite.webui.EmailServices
{
    public interface IEmailSender
    {
        //smtp 

        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
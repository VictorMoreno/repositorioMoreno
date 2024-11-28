using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Peliculas.API.Infraestructura.Emails;

public class SmtpEmailSender : IEmailSender
{
    private readonly IConfiguration _configuration;

    public SmtpEmailSender(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task SendEmailAsync(string email, string asunto, string mensaje)
    {
        var host = _configuration["Smtp:Host"];
        var puerto = int.Parse(_configuration["Smtp:Port"]);
        var emailEmisor = _configuration["Smtp:Username"];
        var password = _configuration["Smtp:Password"];

        var smtpClient = new SmtpClient(host, puerto);
        smtpClient.EnableSsl = true;
        smtpClient.UseDefaultCredentials = false;

        smtpClient.Credentials = new NetworkCredential(emailEmisor, password);
        var mailMessage = new MailMessage(emailEmisor, email, asunto, mensaje);
        mailMessage.IsBodyHtml = true;

        await smtpClient.SendMailAsync(mailMessage).ConfigureAwait(false);
    }
}
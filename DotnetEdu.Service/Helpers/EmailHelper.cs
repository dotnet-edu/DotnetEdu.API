﻿namespace DotnetEdu.Service.Helpers;

public class EmailHelper
{
    public static async ValueTask SendMessageAsync(string to, string subject, string body)
    {
        //var message = new MimeMessage();

        //message.From.Add(MailboxAddress.Parse(EnvironmentHelper.EmailAddress));
        //message.To.Add(MailboxAddress.Parse(to));
        //message.Subject = subject;
        //message.Body = new TextPart(TextFormat.Html)
        //{
        //    Text = body
        //};

        //var smtp = new SmtpClient();

        //await smtp.ConnectAsync(
        //    EnvironmentHelper.SmtpHost,
        //    Convert.ToInt32(EnvironmentHelper.SmtpPort),
        //    SecureSocketOptions.StartTls);

        //await smtp.AuthenticateAsync(
        //    EnvironmentHelper.EmailAddress,
        //    EnvironmentHelper.EmailPassword);
        //await smtp.SendAsync(message);

        //await smtp.DisconnectAsync(true);
    }
}
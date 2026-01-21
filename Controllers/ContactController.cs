using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

[ApiController]
[Route("api/[controller]")]
public class ContactController : ControllerBase
{
    private readonly IConfiguration _config;

    public ContactController(IConfiguration config)
    {
        _config = config;
    }

    [HttpPost]
    public async Task<IActionResult> Send([FromBody] ContactRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name) ||
            string.IsNullOrWhiteSpace(request.Email) ||
            string.IsNullOrWhiteSpace(request.Message))
        {
            return BadRequest(new { message = "All fields are required." });
        }

        try
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_config["EmailSettings:From"]));
            email.To.Add(MailboxAddress.Parse(_config["EmailSettings:To"]));
            email.Subject = $"New Contact from {request.Name}";

            email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = $"""
                        <h3>New Portfolio Message</h3>
                        <p><b>Name:</b> {request.Name}</p>
                        <p><b>Email:</b> {request.Email}</p>
                        <p><b>Message:</b><br/>{request.Message}</p>
                        """
            };

            using var smtp = new SmtpClient
            {
                Timeout = 10000 // ⏱️ 10 seconds max
            };

            await smtp.ConnectAsync(
                _config["EmailSettings:SmtpServer"],
                int.Parse(_config["EmailSettings:Port"]),
                SecureSocketOptions.StartTls
            );

            await smtp.AuthenticateAsync(
                _config["EmailSettings:Username"],
                _config["EmailSettings:Password"]
            );

            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);

            return Ok(new { message = "Message sent successfully!" });
        }
        catch (Exception ex)
        {
            // 👇 DO NOT HANG — always return
            return StatusCode(500, new
            {
                message = "Email service failed",
                error = ex.Message
            });
        }
    }

}

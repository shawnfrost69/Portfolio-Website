using Microsoft.AspNetCore.Mvc;
using PortfolioApi.Models;

[ApiController]
[Route("api/[controller]")]
public class CertificationsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCertifications()
    {
        var certifications = new List<Certification>
        {
            new Certification
            {
                Id = 1,
                Title = "Introduction to Cyber Security",
                Issuer = "TryHackMe",
                IssuedOn = new DateTime(2023, 8, 1),
                CredentialId = "THM-TIARJXYRCB",
                CredentialUrl = "https://tryhackme-certificates.s3-eu-west-1.amazonaws.com/THM-XFPO2VM0ZO.pdf",
                ImageUrl = "/assets/certifications/tryhackme.png"
            },
            new Certification
            {
                Id = 2,
                Title = "Introduction to Cybersecurity",
                Issuer = "Cisco",
                IssuedOn = new DateTime(2023, 7, 1),
                CredentialUrl = "https://placeholder.cert.url/cisco",
                ImageUrl = "/assets/certifications/cisco.png"
            },
            new Certification
            {
                Id = 3,
                Title = "Fortinet Network Security Expert Level 1",
                Issuer = "Fortinet",
                IssuedOn = new DateTime(2023, 7, 1),
                ExpiresOn = new DateTime(2025, 7, 1),
                CredentialId = "Jaiv4qFqmj",
                CredentialUrl = "https://placeholder.cert.url/fortinet",
                ImageUrl = "/assets/certifications/fortinet.png"
            },
            new Certification
            {
                Id = 4,
                Title = "(ISC)² Candidate",
                Issuer = "ISC2",
                IssuedOn = new DateTime(2023, 5, 1),
                ExpiresOn = new DateTime(2024, 5, 1),
                CredentialUrl = "https://placeholder.cert.url/isc2",
                ImageUrl = "/assets/certifications/isc2.png"
            }
        };
        return Ok(certifications);
    }
}
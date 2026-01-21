namespace PortfolioApi.Models;

public class Certification
{
    public int Id { get; set; }

    public string Title { get; set; }           // "Introduction to Cyber Security"
    public string Issuer { get; set; }           // "TryHackMe", "Cisco", "Fortinet"
    
    public DateTime IssuedOn { get; set; }
    public DateTime? ExpiresOn { get; set; }

    public string CredentialId { get; set; }     // THM-TIARJXYRCB
    public string CredentialUrl { get; set; }    // 🔗 placeholder
    public string ImageUrl { get; set; }         // 🖼 placeholder
}

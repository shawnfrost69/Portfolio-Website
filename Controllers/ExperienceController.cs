using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ExperienceController : ControllerBase
{
    [HttpGet]
    public IActionResult GetExperience()
    {
        var experiences = new List<Experience>
            {
                new Experience
                {
                    Id = 1,
                    Company = "Solera Inc.",
                    Role = "Software Engineer II",
                    Duration = "08/2022 – Present",
                    Highlights = new List<string>
                    {
                        "Designed and delivered scalable software solutions as part of a vehicle service platform, reducing customer-reported issues by 30% and improving overall system reliability.",

                        "Built and maintained applications using ASP.NET MVC and ASP.NET Web API across legacy (.NET Framework 4.6.2) and modern (.NET 8) microservices, achieving up to 20% faster response times.",

                        "Developed core features such as the Tax Calculation and Estimation modules, reducing calculation errors by 25% and improving user experience ratings by 10%.",

                        "Implemented a media-enabled Shop Notes system with custom UI and actionable reports, increasing user engagement by 20%.",

                        "Integrated CI/CD pipelines and collaborated in version-controlled environments, cutting deployment time by 40% while improving release stability.",

                        "Performed code reviews and quality improvements, resolving static analysis issues and achieving 90%+ test coverage for better maintainability.",

                        "Contributed to system stability initiatives and release cycles, helping reduce production downtime by 15%."
                    }

                },
                new Experience
                {
                    Id = 2,
                    Company = "Kestra | OpenSource",
                    Role = "Frontend Contributor",
                    Duration = "10/2024 – 11/2025",
                    Highlights = new List<string>
                    {
                        "Enhanced logs section UI/UX using Vue.js, improving responsiveness by 15%.",
                        "Resolved overflow issues and improved navigation for a cleaner interface."
                    }
                }
            };

        return Ok(experiences);
    }
}
    

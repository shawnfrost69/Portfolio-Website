using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class EducationController : ControllerBase
{
    [HttpGet]
    public IActionResult GetEducation()
    {
        var education = new List<Education>
        {
            new Education
            {
                Id = 1,
                Institution = "Netaji Subhas Institute of Technology (NSIT)",
                Degree = "Bachelor of Engineering",
                Duration = "2017 – 2021",
                Location = "New Delhi, India"
            }
        };

        return Ok(education);
    }
}
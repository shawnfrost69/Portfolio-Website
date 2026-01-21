using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SkillsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetSkills()
    {
        var skills = new List<Skill>
        {
            new Skill { Id = 1, Name = "C#", Level = "Advanced" },
            new Skill { Id = 2, Name = "ASP.NET Core", Level = "Intermediate" },
            new Skill { Id = 3, Name = "React / Next.js", Level = "Intermediate" },
            new Skill { Id = 4, Name = "SQL Server", Level = "Intermediate" }
        };

        return Ok(skills);
    }
}
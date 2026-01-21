using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/[controller]")]
public class AchievementsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAchievements()
    {
        var achievements = new List<Achievement>
            {
                new Achievement { Id = 1, Description = "Recognized for implementing SonarQube fixes, improving maintainability." },
                new Achievement { Id = 2, Description = "Enhanced Taxation feature and resolved high-priority customer defects." }
            };

        return Ok(achievements);
    }
}
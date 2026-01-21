using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    // 🔹 TEMP in-memory data (replace with DB later)
    private static readonly List<Project> Projects = new()
    {
        new Project
        {
            Id = 1,
            Title = "Playlist Time Wizard",
            Description = "A Chrome/Edge extension that calculates total YouTube playlist duration and viewing time at different playback speeds using a modern glassmorphism UI.",
            Link = "https://github.com/shawnfrost69/PlayList-Time-Wizard.git",
            Live = "https://microsoftedge.microsoft.com/addons/detail/playlist-time-wizard/akojkakanehiahdkdaknajlhpkceifen",
            Stack = "JavaScript, Chrome Extension (Manifest V3), HTML, CSS (Glassmorphism)",
            Image = "/Images/youtube-extension.png",
            Features = new List<string>
            {
                "Automatically calculates total duration of YouTube playlists using DOM-based parsing",
                "Displays adjusted viewing time for multiple playback speeds (1x to 2x)",
                "Modern glassmorphism tile-based UI inspired by Dribbble design trends",
                "Smooth animated time counters for an engaging user experience",
                "No YouTube API usage, ensuring zero copyright or quota issues",
                "Includes optional donation support via QR code without ads or trackers"
            }
        },
        new Project
        {
            Id = 2,
            Title = "Anand Tech Plast Pvt Ltd – Corporate Website",
            Description = "A modern, responsive corporate website built for a toy manufacturing company, showcasing brands, products, infrastructure, and company values with a professional dark-blue industrial theme.",
            Live = "https://www.anandtechplast.com/",
            Stack = "React, JavaScript, Bootstrap 5, CSS3, Vercel",
            Image = "/Images/atpl.png",
            Features = new List<string>
            {
                "Modern responsive UI with dark-blue industrial theme",
                "Custom hero section with video/image background and animations",
                "Dynamic product category navigation inspired by Zebra-style UI",
                "Mobile-first responsive navbar with collapsible menu",
                "Interactive team carousel using react-slick",
                "Contact section with Google Maps integration",
                "Brand logo linking and external website redirections",
                "Deployed on Vercel with CI/CD via GitHub"
            }
        },
        new Project
        {
            Id = 3,
            Title = "Ball Collision Game",
            Description = "An online playable browser game where players destroy moving targets using projectile-based mechanics.",
            Link = "https://github.com/shawnfrost69/Ball-Game",
            Live = "https://shawnfrost69.github.io/Ball-Game/",
            Stack = "JavaScript, HTML5 Canvas, GSAP",
            Image = "/Images/ball-game.png",
            Features = new List<string>
            {
                "Real-time collision detection between projectiles and moving targets",
                "Smooth animations and burst effects using GSAP (GreenSock Animation Platform)",
                "Dynamic gameplay with responsive controls and visual feedback",
                "Optimized rendering using the Canvas API for performance"
            }
        },
        new Project
        {
            Id = 4,
            Title = "Blog API",
            Description = "REST API for blogging platform with authentication and role-based access.",
            Link = "https://github.com/yourname/blogapi",
            Stack = ".NET, SQL Server",
            Features = new List<string>
            {
                "JWT-based authentication",
                "CRUD operations for posts and comments",
                "Role-based authorization",
                "Clean layered architecture"
            }
        },
       
        new Project
        {
            Id = 5,
            Title = "Real-Time Breath Detection Using Webcam",
            Description = "A webcam-based real-time breath detection system leveraging computer vision and biofeedback techniques.",
            Link = "https://github.com/shawnfrost69/Breath-Detector-With-BioFeedback-Game",
            Stack = "Java, OpenCV, Processing",
            Features = new List<string>
            {
                "Real-time video processing using OpenCV to detect breathing patterns",
                "Visualized respiratory data with dynamic graphs using Processing",
                "Designed three biofeedback-based interactive modes",
                "Applied computer vision techniques for live physiological signal analysis"
            }
        },
    };

    // 🔹 LIST VIEW (Projects Section)
    [HttpGet]
    public IActionResult GetProjects()
    {
        // Return minimal data for list
        var result = Projects.Select(p => new
        {
            p.Id,
            p.Title,
            p.Description,
            p.Link,
            p.Stack
        });

        return Ok(result);
    }

    // 🔹 DETAIL VIEW (Modal)
    [HttpGet("{id}")]
    public IActionResult GetProjectById(int id)
    {
        var project = Projects.FirstOrDefault(p => p.Id == id);

        if (project == null)
            return NotFound(new { message = "Project not found" });

        return Ok(project);
    }
}

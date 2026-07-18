using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Skills()
    {
        ViewData["Title"] = "Skills";

    
        ViewData["SkillCategories"] = new Dictionary<string, string>
    {
        { "Languages", "Java, C++, C#, Python, VBA" },
        { "Web Tech", "HTML, CSS, Bootstrap, ASP.NET Core MVC" },
        { "Databases", "Microsoft Access" },
        { "Tools", "Visual Studio, Git/GitHub, Figma, Cisco Packet Tracer, Adobe Photoshop, Blender" }
    };

        return View();
    }

    public IActionResult About()
    {
        ViewData["Title"] = "About Me";

        ViewData["Paragraph1"] = "I am a forward-thinking student and developer based in Muntinlupa, currently pursuing a Bachelor of Science in Information Technology at Lyceum of alabang. My technical milestones include building full-stack web applications and deploying scalable APIs.";

        ViewData["Paragraph2"] = "I aim to become a Lead Software Engineer, specializing in full-stack cloud development and machine learning integration. Outside of coding, I am an avid trail runner and amateur landscape photographer. These creative, active hobbies keep me grounded and energized, preventing burnout and fueling my problem-solving skills when tackling complex software architecture.";



        return View();
    }


    public IActionResult Projects()
    {
        ViewData["Title"] = "Projects";

        ViewData["ProjectList"] = new List<Dictionary<string, object>>
    {
        new Dictionary<string, object>
        {
            { "Title", "Student Management System – Procedural Core" },
            { "Description", "A modular console application implementing procedural programming fundamentals to record student profiles, evaluate course grade averages, and track academic performance metrics." },
            { "Badges", new[] { "C#" } },
            { "Link", "https://github.com/justin3435-324234/BSIT31E1_PRELIM_H1_MANZANO_JUSTIN.git" }
        },
        new Dictionary<string, object>
        {
            { "Title", "File Ingestion Engine" },
            { "Description", "An extensible backend processing utility implementing the Strategy and Factory Creational design patterns to streamline multi-format file parsing, character stream transformations, and structural schema validation workflows." },
            { "Badges", new[] { "C#" } },
            { "Link", "https://github.com/justin3435-324234/BSIT31E1_PRELIM_H2_MANZANO_JUSTIN.git" }
        },
        new Dictionary<string, object>
        {
            { "Title", "FizzBuzz Logic Evaluation" },
            { "Description", "An algorithmic console application demonstrating control flow architecture, nested conditional branching, and modulo arithmetic evaluations to track sequential numeric outputs." },
            { "Badges", new[] { "C#" } },
            { "Link", "https://github.com/justin3435-324234/BSIT31E1_PRELIM_A1_MANZANO_JUSTIN.git" }
        },
        new Dictionary<string, object>
        {
            { "Title", "Console Calculator Engine" },
            { "Description", "An interactive console application demonstrating continuous event-loop processing, type-conversion validation, error handling for mathematical boundary limitations, and conditional arithmetic evaluation logic." },
            { "Badges", new[] { "C#" } },
            { "Link", "https://github.com/justin3435-324234/BSIT31E1_PRELIM_A2_MANZANO_JUSTIN.git" }
        },
        new Dictionary<string, object>
        {
            { "Title", "Http client starter" },
            { "Description", "A minimalist ASP.NET Core Web API initialization script configuring the dependency injection container, foundational service frameworks, middleware HTTP request routing pipelines, and secure controller endpoints." },
            { "Badges", new[] { "C#", "json" } },
            { "Link", "https://github.com/justin3435-324234/Httpclientstarter-Manzano.git" }
        },
        new Dictionary<string, object>
        {
            { "Title", "Transport Polymorphism Challenge" },
            { "Description", "An object-oriented test harness verifying class hierarchy inheritance, multiple interface implementation, factory-based abstraction instantiation, and runtime polymorphic method behavior across disparate domain entities." },
            { "Badges", new[] { "C#" } },
            { "Link", "https://github.com/justin3435-324234/BSIT_31E1_PRELIM_Q1_Manzano_Justin..git" }
        }
    };

        return View();
    }


    public IActionResult Contact()
    {
        ViewData["Title"] = "Contact";

        
        ViewData["Email"] = "manzanojustin37@gmail.com";
        ViewData["Mobile"] = "+63 969 517 2156";
        ViewData["ResumePath"] = "~/resume.pdf";
        ViewData["ResumeDownloadName"] = "Justin_Resume.pdf";

        
        ViewData["SocialLinks"] = new Dictionary<string, string>
    {
        { "GitHub", "https://github.com/justin3435-324234" },
        { "Facebook", "https://www.facebook.com/profile.php?id=61586793926338" }
    };

        return View();
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
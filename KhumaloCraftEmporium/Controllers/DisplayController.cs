using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace KhumaloCraftEmporium.Controllers;

public class DisplayController : Controller
{
    // 
    // GET: /Display/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /Display/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}
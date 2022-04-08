using Microsoft.AspNetCore.Mvc;

namespace FirstWebPage.Controllers
{
  public class FirstController : Controller
  {
    // what type of route?

    // get
    [HttpGet]
    // tell it what name of route is
    [Route("")] // empty is front page
    public ViewResult Index()
    {

      string[] myArray = new string[] {"ciao", "sup", "three"};
      ViewBag.StringArray = myArray;
      // return "Hello from the controller - edited version";
      return View("Index");
    }


    // get
    [HttpGet]
    // tell it what name of route is
    [Route("/second")] // empty is front page
    public ViewResult Second()
    {

      ViewBag.myVariable = "This is coming from my viewbag";
      return View("Second");
    }

    // post


  }

}
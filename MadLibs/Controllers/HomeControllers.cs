using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public string Welcome() { return "wadddup"; }

    [Route("/madlibs")]
    public ActionResult MadLib(string fieldOne, string fieldTwo, string fieldThree)
    {
      MyMadLib myMadLib = new MyMadLib();
      myMadLib.FieldOne = fieldOne;
      myMadLib.FieldTwo = fieldTwo;
      myMadLib.FieldThree = fieldThree;
      return View(myMadLib);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

  }
}
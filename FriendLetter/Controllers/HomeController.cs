using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    public string Hello() { return "Hello friend!"; }

    public string Goodbye() { return "Goodbye friend.";
  }
}
}
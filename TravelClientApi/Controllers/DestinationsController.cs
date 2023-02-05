using Microsoft.AspNetCore.Mvc;
using TravelClientApi.Models;

namespace TravelClientApi.Controllers;

public class DestinationsController : Controller
{
  public IActionResult Index()
  {
    List<Destination> destinations = Destination.GetDestinations();
    return View(destinations);
  }

  public IActionResult Details(int id)
  {
    Destination destination = Destination.GetDetails(id);
    return View(destination);
  }
}
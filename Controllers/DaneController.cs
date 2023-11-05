using FormMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormMvc.Controllers;

public class DaneController : Controller
{
    
    [HttpGet]
    public IActionResult Form()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Form(DaneModel daneModel)
    {
        if(ModelState.IsValid)
        {
            if (daneModel.Haslo == daneModel.PotwierdzenieHasla)
            {
                return View("Wynik");
            }
            else
            {
                ModelState.AddModelError("PotwierdzenieHasla", "Hasło i jego potwierdzenie nie są zgodne.");
                return View();
            }
        }
        else
        {
            return View();
        }
    }
    public IActionResult Wynik(DaneModel daneModel)
    {
        return View(daneModel);
    }
    
}
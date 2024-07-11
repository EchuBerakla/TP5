using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Tutorial()
    {
        return View();
    }

    public IActionResult Comenzar()
{
    int estadoJuego = Escape.GetEstadoJuego();

    if (estadoJuego > 4)
    {
        return View("Victoria");
    }

    ViewBag.Sala = estadoJuego;

    return View($"habitacion{estadoJuego}");
}   
    public IActionResult Habitacion(int sala, string clave)
{
    bool esCorrecta = Escape.ResolverSala(sala, clave);

    if (!esCorrecta)
    {
        ViewBag.Error = "La respuesta escrita fue incorrecta.";
    }

    ViewBag.Sala = sala;

    int estadoJuego = Escape.GetEstadoJuego();
    if (estadoJuego > 4)
    {
        return View("Victoria");
    }

    return View($"habitacion{estadoJuego}");
}


    public IActionResult Victoria(string nombreJugador)
{
    ViewBag.NombreJugador = nombreJugador; 
    return View();
}

    public IActionResult Creditos()
    {
        return View();
    }

   
   
}

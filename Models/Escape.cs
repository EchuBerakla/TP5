using System;

public static class Escape
{
    private static string[] incognitasSalas = { "zombies", "6", "AHEMLLELTP", "investigadores" , "biblia" };
    private static int estadoJuego = 1;

    public static void InicializarJuego()
    {
        incognitasSalas = new string[] { "zombies", "6", "AHEMLLELTP" , "Investigadores" , "biblia"};
        estadoJuego = 1;
    }

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }

    public static bool ResolverSala(int sala, string incognita)
    {
        if (incognitasSalas.Length == 0)
        {
            InicializarJuego();
        }

        if (sala != estadoJuego)
        {
            return false;
        }

        if (incognitasSalas[sala - 1] == incognita)
        {
            estadoJuego++;
            return true; 
        }
        else
        {
            return false; 
        }
    }

}

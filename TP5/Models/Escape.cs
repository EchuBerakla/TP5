using System;

public static class Escape
{
    private static string[] incognitasSalas = { "clave1", "clave2", "clave3", "clave4" };
    private static int estadoJuego = 1;
    
    public static void InicializarJuego()
    {
        incognitasSalas = new string[] { "clave1", "clave2", "clave3", "clave4" };
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

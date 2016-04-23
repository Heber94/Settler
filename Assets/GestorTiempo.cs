using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;


static class GestorTiempo
{
    static int Velocidad;
    static int velocidad
    {
        get
        {
            return velocidad;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("La velocidad no puede ser negativa");
            }
            Velocidad = value;
        }

    }
    static float segundo;
    static public Fecha fechaActual = new Fecha(0, 0, 0, 0);


    public static Fecha FechaActual
    {
        get
        {
            return fechaActual;
        }
    }

    public static void Update()
    {
        segundo += Time.deltaTime * velocidad;
        while (segundo > 1)
        {
            fechaActual = fechaActual + 1;
            segundo -= 1;
        }
    }

}


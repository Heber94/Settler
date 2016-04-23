using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public abstract class Evento : IMostrarInterfaz
{

    public Image Icono;
    public String Nombre;
    public Fecha FechaInicio;
    public Fecha FechaFin;
    public bool solucionado;

    public abstract void Inicio();
    public abstract void Tick();
    public abstract void Fin();

    void Solucion(int numero) { }

    //Interfaz 
    public string nombre()
    {
        return Nombre;
    }

    public Image imagen()
    {
        return Icono;
    }

    public int valor()
    {
        return (FechaFin - GestorTiempo.FechaActual) / FechaFin * 100;
    }

    public int valorMaximo()
    {
        return 100;
    }
}

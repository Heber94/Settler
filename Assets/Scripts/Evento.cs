using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public abstract class Evento : IMostrarInterfaz
{
    /// <summary>
    /// icono a mostrar en la UI
    /// </summary>
    public Image Icono;
    /// <summary>
    /// Nombre en la UI
    /// </summary>
    public String Nombre;
    /// <summary>
    /// Fecha de inicio
    /// </summary>
    public Fecha FechaInicio;
    /// <summary>
    /// Fecha de fin
    /// </summary>
    public Fecha FechaFin;
    /// <summary>
    /// solucion aplicada 
    /// </summary>
    public bool solucionado;

    /// <summary>
    /// funcion llamada al inicio
    /// </summary>
    public abstract void Inicio();
    /// <summary>
    /// Funcionm llamada cada Update
    /// </summary>
    public abstract void Tick();
    /// <summary>
    /// Funcion llamada al finalizar el vento
    /// </summary>
    public abstract void Fin();

    /// <summary>
    /// Para aplicar la solucion
    /// </summary>
    /// <param name="numero"></param>
    public void Solucion(int numero) { }

    //Interfaz para mostrar por la UI
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

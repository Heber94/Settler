using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;


public class GestorDeEventos : MonoBehaviour
{
    List<Evento> Eventos = new List<Evento>();
    Fecha SiguienteEvento;
    System.Random rnd = new System.Random();

    void Start()
    {


        SiguienteEvento = new Fecha(0, 0, rnd.Next(500, 1000), 0, 0) + GestorTiempo.FechaActual;
    }

    void Update()
    {
        //ejecutar funciones de los eventos
        foreach (Evento e in Eventos)
        {
            if (e.FechaFin > GestorTiempo.fechaActual)
            {
                e.Fin();
            }
            else
            {
                e.Tick();
            }
        }
        //eliminar eventos terminados
        Eventos.RemoveAll(x => x.FechaFin > GestorTiempo.fechaActual);

        if (SiguienteEvento > GestorTiempo.FechaActual)
        {

            SiguienteEvento = new Fecha(0, 0, rnd.Next(500, 1000), 0, 0) + GestorTiempo.FechaActual;
            Evento nuevoEvento;
            nuevoEvento = new TodosLosEventos.TormentaArena();
            nuevoEvento.Inicio();
            Eventos.Add(nuevoEvento);

        }


    }
}


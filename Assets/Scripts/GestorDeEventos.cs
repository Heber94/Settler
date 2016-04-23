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

   
        SiguienteEvento = new Fecha(0, 0, rnd.Next(500, 1000),0,0) + GestorTiempo.FechaActual;
    }

    void Update()
    {
        foreach (Evento e in Eventos)
        {
            e.Tick();
        }

        if (SiguienteEvento > GestorTiempo.FechaActual) {

            SiguienteEvento = new Fecha(0, 0, rnd.Next(500, 1000),0, 0) + GestorTiempo.FechaActual;


         //   Eventos.Add(new TodosLosEventos.TormentaArena());

        }


    }
}


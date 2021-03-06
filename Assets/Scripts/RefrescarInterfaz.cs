﻿using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public partial class RefrescarInterfaz : MonoBehaviour
{
    public Text fecha;
    public Text personas;
    public Text energia;
    public Text agua;
    public Text comida;
    public Text oxigeno;
    public Text ciencia;
    public Slider BarraVelocidad;
    //public ResourceManager GestorRecursos;

    // Use this for initialization
    void Start()
    {
        ResourceManager.InitResourceManager(100, 30,620, 62,78, 9,12);
        cameraPlayable = true;
        speedCamera = .1f;
        speedZoom = 20f;

        /*	displayEnergy.text = "";
            displayScience.text = "";
            displayWater.text = "";
            displayFood.text = "";
            displayOxygen.text = "";
            displayPopulation.text = "";
            displayMaterials.text = "";*/

        ChangeResourcesText();
    }

    // Update is called once per frame
    void Update()
    {
        fecha.text = GestorTiempo.FechaActual.ToString();
        personas.text = ResourceManager.getPopulation().ToString();
        energia.text = ResourceManager.getEnergy().ToString();
        agua.text = ResourceManager.getWater().ToString();
        comida.text = ResourceManager.getFood().ToString();
        oxigeno.text = ResourceManager.getOxygen().ToString();
        ciencia.text = ResourceManager.getScience().ToString();


        ControlCameras();
        ChangeResourcesText();



    }

    public void CambiarVelocidad()
    {
        print(BarraVelocidad.value);
        GestorTiempo.velocidad = (int)Mathf.Exp( BarraVelocidad.value);
    }
}

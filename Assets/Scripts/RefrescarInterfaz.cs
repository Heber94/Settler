using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class RefrescarInterfaz : MonoBehaviour
{
    public Text fecha;
    public Text personas;
    public Text energia;
    public Text agua;
    public Text comida;
    public Text oxigeno;
    //public ResourceManager GestorRecursos;

    // Use this for initialization
    void Start()
    {
        ResourceManager.InitResourceManager(0, 0, 0, 0, 0, 0, 0);
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




    }
    public void AumentarVelocidad()
    {
        GestorTiempo.velocidad = 100000;
    }
}

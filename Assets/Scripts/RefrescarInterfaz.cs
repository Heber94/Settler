using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class RefrescarInterfaz : MonoBehaviour
{
    public Text fecha;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fecha.text = GestorTiempo.FechaActual.ToString();
    }
    public void AumentarVelocidad()
    {
        GestorTiempo.velocidad = 100000;
    }
}

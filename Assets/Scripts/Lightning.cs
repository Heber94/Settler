using UnityEngine;
using System.Collections;

public class Lightning : MonoBehaviour
{

   // public GameObject sun;
   // public GameObject deimos;
    ulong lastSeconds = 0;
    ulong tiempoDia = 24 * 60 * 60;
    void Update()
    {
        ulong secsActual = GestorTiempo.FechaActual.ToSeconds() % tiempoDia;
        transform.rotation = Quaternion.AngleAxis(((float)(secsActual) /(float) tiempoDia) * 360, Vector3.left);//Vector3.zero, Vector3.left,((float)(secsActual-lastSeconds)/tiempoDia)*360);
        transform.rotation *= Quaternion.AngleAxis(180, Vector3.left);
        lastSeconds = secsActual;

    }
}
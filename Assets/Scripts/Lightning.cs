using UnityEngine;
using System.Collections;

public class Lightning : MonoBehaviour
{

    public GameObject sun;
    public GameObject deimos;
    ulong lastSeconds = 0;

    void Update()
    {
        ulong secsActuales = GestorTiempo.FechaActual.ToSeconds();
        if (lastSeconds > secsActuales)
        {
            lastSeconds = 0;
        }
        ulong secsTranscurridos = secsActuales - lastSeconds;
        print(GestorTiempo.FechaActual.ToString());

        if (secsActuales > lastSeconds)
        {
            print("Secs actuales: " + secsActuales);
            print("Last seconds: " + lastSeconds);
            print("Transcurridos: " + secsTranscurridos);
            //(260/(24*60*60)) = 0.004166666667
            double rotation = secsTranscurridos * 0.004166666667;
            print("Rotation: " + rotation.ToString());
            lastSeconds = secsActuales;
            transform.RotateAround(Vector3.zero, Vector3.left, (float)rotation);
        }

        //	void Update () {
        //		float rotation = (GestorTiempo.FechaActual.ToSeconds()%(24*60*60))/(24*60*60);
        //		//	print (rotation);
        //		print (GestorTiempo.FechaActual.ToString ());
        //		//transform.RotateAround (Vector3.zero, Vector3.left, rotation); 
        //		transform.rotation = Quaternion.AngleAxis (rotation *2*Mathf.PI , Vector3.left);
        //	}
    }
}
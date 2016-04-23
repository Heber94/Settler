using UnityEngine;
using System.Collections;

public class Lightning : MonoBehaviour {

	public GameObject sun;
	public GameObject deimos;
	float secsDay = 24*60*60;
	float rotationPerSec = 360 / 24 * 60 * 60;
	float lastDate = 0;
	
	// Update is called once per frame
	void Update () {
		float rotation = GestorTiempo.FechaActual.ToSeconds () - lastDate;
		transform.RotateAround (Vector3.zero, Vector3.left, rotation); 

	}
}

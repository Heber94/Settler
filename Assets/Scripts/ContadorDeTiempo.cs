using UnityEngine;
using System.Collections;

public class ContadorDeTiempo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GestorTiempo.Update();
	}
}

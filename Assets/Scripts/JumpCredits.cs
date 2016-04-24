using UnityEngine;
using System.Collections;

public class JumpCredits : MonoBehaviour {


	void Update () {
	    if (transform.position.y > 800)
        {
            Application.LoadLevel("titleScene");
        }
	}
}

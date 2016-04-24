using UnityEngine;
using System.Collections;

public class ScrollText : MonoBehaviour {

    public float speed = 2;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 1, 0);
    }
}

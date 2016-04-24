using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.Audio;

public class PlaceableBuilding : MonoBehaviour {

    


    [HideInInspector]
    public List<Collider> colliders = new List<Collider>();
    public AudioSource placed;

   // public ResourceManager res;

    private Rigidbody rb;
    //public bool buildingZone;

    public int health = 100;
    public int strenght = 100;
    public int level = 1;
    public int populationInside = 0;

    public int scienceAmountNecesary;
    public int populationAmountNecesary;
    public int MaterialsAmountNecesary;

    
    void Awake()
    {
       // res = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().resMan;
        rb = GetComponent<Rigidbody>();
    }


    
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Building")
        {
            colliders.Add(c);
        }

        if (c.tag == "Terrain")
        {

            placed.Play();
            rb.isKinematic = true;
            rb.useGravity = false;
        }
   
    }


    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Building")
        {
            colliders.Remove(c);
        }
        if (c.tag == "Terrain")
        {
            rb.isKinematic = false;
            rb.useGravity = true;
        }
    }
}

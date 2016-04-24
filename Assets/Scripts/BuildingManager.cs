using UnityEngine;
using System.Collections;

public class BuildingManager : MonoBehaviour
{


    public GameObject[] buildings;

    private BuildingPlacement buildingPlacement;

    [HideInInspector]
    public int[] buildingAmount = new int[5];



    // Use this for initialization
    void Start()
    {

        buildingPlacement = GetComponent<BuildingPlacement>();

        for (int i = 0; i < buildings.Length; i++)
        {
            buildingAmount[i] = 0;
        }
    }

    void Update()
    {

        /*  if (Input.GetKey(KeyCode.A)){
              buildingPlacement.SetItem(buildings[0]);
          }*/
    }
    public void ConstruirEdificio(int n)
    {
        buildingPlacement.SetItem(buildings[n]);
    }
    /* void OnGUI()
     {
         for (int i = 0; i < buildings.Length; i++){
             if (GUI.Button(new Rect(Screen.width / 20, Screen.height / 15 + Screen.height / 12 * i,100,30), buildings[i].name))
             {
                 buildingPlacement.SetItem(buildings[i]);
             }
         }
     }*/
}

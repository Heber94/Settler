using UnityEngine;
using System.Collections;

public class BuildingPlacement : MonoBehaviour {

    private Terrain terrain;
    private PlaceableBuilding placeableBuilding;
    private Transform currentBuilding;
    private Rigidbody rb;
    private bool hasPlaced;

    [Header("Seleccionar lugares de construccion")]
    public LayerMask Terreno;

    [Header("Cameras")]
    //Camera from above
    public GameObject cameraPlayableObject;
    private Camera viewCamera;

   // ResourceManager resources;

    private float height = 0;

    public float gridSize  = .1f;


    void Awake()
    {
        
        viewCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

        //resources = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().resMan;
    }



    void Start()
    {
        terrain = FindObjectOfType<Terrain>();
    }

	// Update is called once per frame
	void Update () {

        if (viewCamera.enabled)
        {

            Vector3 m = Input.mousePosition;
            m = new Vector3(m.x, m.y, transform.position.y);
            Vector3 pos = viewCamera.ScreenToWorldPoint(m);
            //height = terrain.terrainData.GetHeight((int)pos.x,(int)pos.y);

            if (currentBuilding != null)
            {
                if (!hasPlaced)
                {
                    Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    Vector3 newPos;
                    if (Physics.Raycast(ray, out hit,Mathf.Infinity, Terreno))
                    {
                        newPos = new Vector3(Mathf.Round( hit.point.x/gridSize) *gridSize, 7, Mathf.Round(hit.point.z / gridSize)*gridSize);
                        currentBuilding.position = newPos;
                    }
                  

                }

                if (Input.GetMouseButtonDown(0) && IsLegalPosition())//Is allowBuild

                {

                    hasPlaced = true;
                    print(ResourceManager.getEnergy().getAmount());


                }

                if (Input.GetMouseButtonDown(1) && hasPlaced == false)
                {
                    //currentBuilding.Rotate(Vector3.right * 90);
                    currentBuilding.Rotate(0,0,90);
                }
            }
        }
    }

    bool IsLegalPosition()
    {
       if (placeableBuilding.colliders.Count > 0)
        {
            return false;
        }

    return true;
        
    }

   public void SetItem(GameObject b)
    {
        hasPlaced = false;
        currentBuilding = ((GameObject)Instantiate(b)).transform;
        placeableBuilding = currentBuilding.GetComponent<PlaceableBuilding>();
    }
}

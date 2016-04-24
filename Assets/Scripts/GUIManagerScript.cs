using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public partial class RefrescarInterfaz : MonoBehaviour
{

    /**
	 * Cameras
	 */
    [Header("Cameras")]
    //Camera in isometric
    //private GameObject cameraVisualObject;
    //Camera from above
    private GameObject cameraPlayableObject;
    //private Camera cameraVisual;
    //private Camera cameraPlayable;
    public GameObject cameraObject;
   // private Camera camera;
    private bool cameraPlayable;
    public float speedCamera;
	public float speedZoom;


	[Header("Camera Limits")]
	int MAX_X = 150;
	int MIN_X = -110;
	int MAX_Z = 90;
	int MIN_Z = -90;

	/**
	 * Textos que se mostrarán por pantalla
	 */

	//public Text[] display;
	/*[Header("Texts")]
	public Text displayEnergy;
	public Text displayScience;
	public Text displayWater;
	public Text displayFood;
	public Text displayOxygen;
	public Text displayPopulation;
	public Text displayMaterials;*/

	/**
	 * Resources
	 * Energy, Food, Oxygen, Science, Water, Population, Materials
	 */

	/**
	 * Called in the begining
	 * Search for the cameras components on cameras objects
	 */

	void Awake(){
        //cameraVisual = cameraVisualObject.GetComponent<Camera> ();
        //cameraPlayable = cameraPlayableObject.GetComponent<Camera> ();
        //camera = cameraObject.GetComponent<Camera>();
        cameraPlayableObject = GameObject.FindGameObjectWithTag("MainCamera");
    }

	/**
	 * Called in the begining after the Awake function
	 * Initialize all the variables 
	 */

	/**
	 * Called once per frame
	 * Every frame you can change between cameras or control one of them
	 * Also the text on the GUI is updated every frame
	 */


	/**
	 * Change the text that is displayed on the GUI depending on the values of the resources
	 */

	public void ChangeResourcesText(){
		//displayEnergy.text = ResourceManager.getEnergy().getName() + " : " + ResourceManager.getEnergy().getAmount();
		/*displayScience.text = resources.getScience().getName() + " : " + resources.getScience().getAmount();
		displayWater.text = resources.getWater().getName() + " : " + resources.getWater().getAmount();
		displayFood.text = resources.getFood().getName() + " : " + resources.getFood().getAmount();
		displayOxygen.text = resources.getOxygen().getName() + " : " + resources.getOxygen().getAmount();
		displayPopulation.text = resources.getPopulation().getName() + " : " + resources.getPopulation().getAmount();
		displayMaterials.text = resources.getMaterials().getName() + " : " + resources.getMaterials().getAmount();*/
	}

	/**
	 * Hide the interface and all the values
	 */

	void HideText(){
		/*displayEnergy.enabled = false;
		displayScience.enabled = false;
		displayWater.enabled = false;
		displayFood.enabled = false;
		displayOxygen.enabled = false;
		displayPopulation.enabled = false;
		displayMaterials.enabled = false;*/
	}

	/**
	 * Display the interface and all the values
	 */

	void DisplayText(){
		/*displayEnergy.enabled = true;
		displayScience.enabled = true;
		displayWater.enabled = true;
		displayFood.enabled = true;
		displayOxygen.enabled = true;
		displayPopulation.enabled = true;
		displayMaterials.enabled = true;*/
	}

	/**
	 * Allows the user to moves the cameras depending on what is active
	 */

	public void ControlCameras(){
			//Camera to the right
			if ((Input.GetKey(KeyCode.S) && !cameraPlayable) || (Input.mousePosition.y <= (Screen.height * 0.05) && cameraPlayable)) {
				cameraObject.transform.position = new Vector3 (
					cameraObject.transform.position.x, 
					cameraObject.transform.position.y, 
					cameraObject.transform.position.z - (1 * speedCamera));
			}
			//Camera to the left
			if ((Input.GetKey(KeyCode.W) && !cameraPlayable)|| (Input.mousePosition.y >= (Screen.height * 0.95) && cameraPlayable)) {
				cameraObject.transform.position = new Vector3 (
					cameraObject.transform.position.x, 
					cameraObject.transform.position.y, 
					cameraObject.transform.position.z + (1 * speedCamera));
			}
			//Camera to the top
			if ((Input.GetKey (KeyCode.D) && !cameraPlayable) || (Input.mousePosition.x >= (Screen.width * 0.95) && cameraPlayable))
        {
            cameraObject.transform.position = new Vector3 (
					cameraObject.transform.position.x + (1 * speedCamera), 
					cameraObject.transform.position.y, 
					cameraObject.transform.position.z);
			}
			//Camera to the bottom
			if ((Input.GetKey (KeyCode.A) && !cameraPlayable) || (Input.mousePosition.x <= (Screen.width * 0.05) && cameraPlayable)) {
				cameraObject.transform.position = new Vector3 (
					cameraObject.transform.position.x - (1 * speedCamera), 
					cameraObject.transform.position.y, 
					cameraObject.transform.position.z);
			}
		if(cameraPlayable) {
			//Zoom in
			if(Input.GetAxis("Mouse ScrollWheel") > 0 && cameraPlayableObject.transform.position.y <= 100){
				cameraPlayableObject.transform.position = new Vector3(
					cameraPlayableObject.transform.position.x, 
					cameraPlayableObject.transform.position.y + (1 * speedCamera * speedZoom), 
					cameraPlayableObject.transform.position.z);
			}
			//Zoom out
			if(Input.GetAxis("Mouse ScrollWheel") < 0 && cameraPlayableObject.transform.position.y >= 10){
				cameraPlayableObject.transform.position = new Vector3(
					cameraPlayableObject.transform.position.x, 
					cameraPlayableObject.transform.position.y - (1 * speedCamera * speedZoom), 
					cameraPlayableObject.transform.position.z);
			}
		}
	}

	/**
	 * Change between cameras by pressing space
	 */

	public void ChangeCameras(){
        //print("Cambiando");
        //if (Input.GetKeyDown(KeyCode.Space)) {
        //cameraVisual.enabled = !cameraVisual.enabled;
        //cameraPlayable.enabled = !cameraPlayable.enabled;
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled;
        GameObject.FindGameObjectWithTag("Camera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("Camera").GetComponent<Camera>().enabled;
        cameraPlayable = !cameraPlayable;
        //}
    }
		
}
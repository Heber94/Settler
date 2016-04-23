using UnityEngine;
using System.Collections;

public class ResourceManager : MonoBehaviour {

	Resource [] resources = new Resource[7];

	public ResourceManager(	int amountEnergy, int amountFood, int amountOxygen, 
		int amountScience, int amountWater, int amountMattDamons, int amountMaterials){

		resources [0] = new Resource ("Energy", amountEnergy); 
		resources [1] = new Resource ("Food", amountFood); 
		resources [2] = new Resource ("Oxygen", amountOxygen); 
		resources [3] = new Resource ("Science", amountScience); 
		resources [4] = new Resource ("Water", amountWater); 
		resources [5] = new Resource ("Population", amountMattDamons); 
		resources [6] = new Resource ("Materials", amountMaterials); 
	}

	public Resource getEnergy(){
		return resources [0];
	}

	public Resource getFood(){
		return resources [1];
	}

	public Resource getOxygen(){
		return resources [2];
	}

	public Resource getScience(){
		return resources [3];
	}

	public Resource getWater(){
		return resources [4];
	}

	public Resource getPopulation(){
		return resources [5];
	}

	public Resource getMaterials(){
		return resources [6];
	}

	public bool build(int amountEnergy, int amountFood, int amountOxygen, 
		int amountScience, int amountWater, int amountMattDamons, int amountMaterials){

		if (resources [0].getAmount() >= amountEnergy && resources [1].getAmount() >= amountFood
			&& resources [2].getAmount() >= amountOxygen && resources [3].getAmount() >= amountScience
			&& resources [4].getAmount() >= amountWater && resources [5].getAmount() >= amountMattDamons
			&& resources [6].getAmount() >= amountMaterials) {

			resources [0].setAmount(resources [0].getAmount() - amountEnergy);
			resources [1].setAmount(resources [1].getAmount() -amountFood);
			resources [2].setAmount(resources [2].getAmount()- amountOxygen);
			resources [3].setAmount(resources [3].getAmount() - amountScience);
			resources [4].setAmount(resources [4].getAmount() - amountWater);
			resources [5].setAmount(resources [5].getAmount() - amountMattDamons);
			resources [6].setAmount(resources [5].getAmount() - amountMaterials);

			return true;

		} else {
			
			return false;

		}
	}

}

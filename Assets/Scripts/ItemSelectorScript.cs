using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ItemSelectorScript : MonoBehaviour
{
    public AudioSource click;
    public int max = 100;
    private int currentItems;

    private int food;
    private int water;
    private int energy;
    private int oxygen;
    private int population;
    private int materials;

    [Header("Sliders")]
    public Slider foodSlider;
    public Slider waterSlider;
    public Slider energySlider;
    public Slider oxygenSlider;
    public Slider populationSlider;
    public Slider materialsSlider;

    [Header("Texts")]
    public Text foodText;
    public Text waterText;
    public Text energyText;
    public Text oxygenText;
    public Text populationText;
    public Text materialsText;
    public Text totalText;

    void Start()
    {
        currentItems = 0;
        foodText.text = "";
        waterText.text = "";
        energyText.text = "";
        oxygenText.text = "";
        populationText.text = "";
        materialsText.text = "";
        totalText.text = currentItems.ToString() + " / " + max.ToString();
    }

    void Update()
    {
        currentItems = (SetFood() + SetWater() + SetEnergy() + SetOxygen() + SetPopulation() + SetMaterials());
        totalText.text = currentItems.ToString() + " / " + max.ToString();
        if (currentItems >= 100)
        {
            click.Play();
            Application.LoadLevel("Escenas/04 - InGame");
        }
    }

    public int SetFood()
    {
        if (currentItems < max)
        {
            food = (int)foodSlider.value;
            foodText.text = food.ToString();
        }
        return food;
    }

    public int SetWater()
    {
        if (currentItems < max)
        {
            water = (int)waterSlider.value;
            waterText.text = water.ToString();
        }
        return water;
    }

    public int SetEnergy()
    {
        if (currentItems < max)
        {
            energy = (int)energySlider.value;
            energyText.text = energy.ToString();
        }
        return energy;
    }

    public int SetOxygen()
    {
        if (currentItems < max)
        {
            oxygen = (int)oxygenSlider.value;
            oxygenText.text = oxygen.ToString();
        }
        return oxygen;
    }

    public int SetPopulation()
    {
        if (currentItems < max)
        {
            population = (int)populationSlider.value;
            populationText.text = population.ToString();
        }
        return population;
    }

    public int SetMaterials()
    {
        if (currentItems < max)
        {
            materials = (int)materialsSlider.value;
            materialsText.text = materials.ToString();
        }
        return materials;
    }

}

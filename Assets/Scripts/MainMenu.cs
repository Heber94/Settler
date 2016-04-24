using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour {
    public AudioSource click;


    public void LoadStart()
    {
        click.Play();
        Application.LoadLevel("02 - description");
    }

    public void LoadCredits()
    {
        click.Play();
        Application.LoadLevel("credits");
    }

    public void LoadMain()
    {
        click.Play();
        Application.LoadLevel("Escenas/04 - InGame");
    }

    public void LoadResources()
    {
        click.Play();
        Application.LoadLevel("Resources");
    }

    public void NotAsigned()
    {
        click.Play();
    }

}

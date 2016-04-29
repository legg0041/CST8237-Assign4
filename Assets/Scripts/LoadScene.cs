using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour {

    //the sound to play on button press
    public AudioSource sound;
    //the name of the scene to go to
    private string _name;

    /// <summary>
    /// Plays the sound, sets the scene name, and invokes the function after 1.5 seconds
    /// </summary>
    /// <param name="name">The name of the scene to load</param>
	public void SceneLoader(string name)
    {
        //the sound to play
        sound.Play();
        //set the scene to load, received from the button
        _name = name;
        //in 1.5s call the sceneload function
        Invoke("ActuallyLoadLevel", 1.5f);
    }

    /// <summary>
    /// Used to load the scene received from the button
    /// </summary>
    protected void ActuallyLoadLevel()
    {
        SceneManager.LoadScene(_name);
    }
}

using UnityEngine;
using System.Collections;

public class HorizontalSpin : MonoBehaviour
{

    //speed to rotate the object
    private int rotateSpeed = 100;
    //the sound to be played on collsion
    public AudioSource sound;
    //the gamecontroller script
    private GameController _Game;

    void Start()
    {
        //set the gamecontroller script
        _Game = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        //rotate the object
        transform.Rotate(0, 0, Time.deltaTime * rotateSpeed);
    }

    /// <summary>
    /// This can be triggered by the players bullets or themselves allowing for quick stacking of points
    /// </summary>
    /// <param name="coll"></param>
    void OnTriggerEnter(Collider coll)
    {
        //play the points sound
        sound.Play();
        //add the points
        _Game.AddRingPoints();
    }
}

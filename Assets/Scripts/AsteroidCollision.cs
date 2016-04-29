using UnityEngine;
using System.Collections;

public class AsteroidCollision : MonoBehaviour {

    //the gamecontroller script
    private GameController _Game;

	// Use this for initialization
	void Start () {
        //set the gamecontroller script
        _Game = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	}

    void OnTriggerEnter(Collider coll)
    {
        //cause damage to be taken
        _Game.TakeDamage();
    }
}

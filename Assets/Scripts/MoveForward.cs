using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

    //the speed at which to move the player forward
    public float moveSpeed = 15f;
    	
	// Update is called once per frame
	void Update () {
        //move the object forward at said speed
        transform.position += (new Vector3(0, 0, moveSpeed)) * Time.deltaTime;

    }
}

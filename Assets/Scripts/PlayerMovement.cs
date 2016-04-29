using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    //the speed at which the player moves
    public float playerSpeed = 8.0f;
	
	// Update is called once per frame
	void Update ()
    {
        //get the horizontal and vertical directions being pressed
        float horiFloat = Input.GetAxis("Horizontal");
        float vertFloat = Input.GetAxis("Vertical");
        //create a new vector using these inputs
        Vector3 direction = new Vector3(horiFloat, vertFloat, 0);
        //change the position using the direction, playerspeed, and time
        transform.localPosition += direction * playerSpeed * Time.deltaTime;
        //rotate the player towards the direction they are inputing
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(direction), Mathf.Deg2Rad * 35f);
   
	}
}

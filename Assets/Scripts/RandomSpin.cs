using UnityEngine;
using System.Collections;

public class RandomSpin : MonoBehaviour {
    	
	// Update is called once per frame
	void Update () {
        //generate 3 random floats used to randomly rotate the object
        float tempX = Random.Range(0f,50f) * Time.deltaTime;
        float tempY = Random.Range(0f, 50f) * Time.deltaTime;
        float tempZ = Random.Range(0f, 50f) * Time.deltaTime;
        //set the rotation
        transform.Rotate(tempX, tempY, tempZ);
    }
}

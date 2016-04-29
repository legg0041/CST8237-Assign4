using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

    //the bullet to be spawned
    public Rigidbody bullet;
    //the collider of the ship
    public BoxCollider box;
    //the speed to move the bullets at
    public float bulletSpeed = 50f;
    //whether its currently spinning
    private bool _isBarrel = false;
    //the length of the roll
    private float barrelRollDuration = 0.5f;
	
	// Update is called once per frame
	void Update ()
    {
        //if left mouse is pressed
	    if(Input.GetButtonDown("Fire1"))
        {
            //spawn a new bullet
            Rigidbody newBullet = Instantiate(bullet, transform.position, bullet.transform.rotation) as Rigidbody;
            //add force causing it to shoot forwards
            newBullet.AddForce(transform.forward * bulletSpeed, ForceMode.VelocityChange);
        }
        else
        {
            //if right mouse is pressed
            if(Input.GetButtonDown("Fire2"))
            {
                //if not currently spinning
                if(_isBarrel == false)
                {
                    //check which direction they are moving in to spin left or right
                    if (Input.GetAxis("Horizontal") > 0)
                    {
                        StartCoroutine(BarrelRoll(false));
                    }
                    else
                    {
                        StartCoroutine(BarrelRoll(true));
                    }
                }
            }
        }
	}

    //provided by Sean Macfarlane
    IEnumerator BarrelRoll(bool direction)
    {
        //the roll has started
        _isBarrel = true;
        //t dureation of the roll so far
        float t = 0.0f;
        //which direction to spin in
        int invert = 1;
        //set direction
        if (direction == false)
        {
            invert = -1;
        }
        //get current rotation
        Vector3 initialRotation = transform.localRotation.eulerAngles;
        //create new rotation to use
        Vector3 goalRotation = initialRotation;
        goalRotation.z += 360.0f * invert;
        Vector3 currentRotation = initialRotation;
        //disable the collider so player is invincible, player can still get points by shooting the rings instead
        box.enabled = false;
        //until roll is finished
        while (t < barrelRollDuration)
        {
            //roll the player in the direction
            currentRotation.z = Mathf.Lerp(initialRotation.z, goalRotation.z, t / barrelRollDuration);
            transform.localRotation = Quaternion.Euler(currentRotation);
            t += Time.deltaTime;
            yield return null;
        }
        //reenable collider
        box.enabled = true;
        //roll is finished
        _isBarrel = false;
    }
}

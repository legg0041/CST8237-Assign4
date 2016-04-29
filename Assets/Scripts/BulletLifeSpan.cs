using UnityEngine;
using System.Collections;

public class BulletLifeSpan : MonoBehaviour {

    //the bullet sound when fired
    public AudioSource sound;

	// Use this for initialization
	void Start () {
        //play the bullet sound
        sound.Play();
        //start coroutine
        StartCoroutine(LifeSpan());
	}

    /// <summary>
    /// Wait for 3 seconds and then destroy the bullet
    /// </summary>
    /// <returns></returns>
    IEnumerator LifeSpan()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}

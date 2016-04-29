using UnityEngine;
using System.Collections;

public class DoNotDestroy : MonoBehaviour {

    //single instance of this object
    public static DoNotDestroy instance;

    // Use this for initialization
    void Start ()
    {
        //if it exists destroy the duplicate created
        if (instance)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            //tell it not to be destroyed and set the instance
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
    }

}

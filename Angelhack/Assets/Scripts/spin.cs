using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour {

    public float degreesPerSecond;
    public string clockwise;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(clockwise == "True"){
            transform.Rotate(Vector3.back * Time.deltaTime * degreesPerSecond);
        }
        else{
            transform.Rotate(Vector3.forward * Time.deltaTime * degreesPerSecond);
        }
    }
}

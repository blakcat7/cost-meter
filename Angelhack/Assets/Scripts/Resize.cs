using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour {

    public GameObject ui;

	// Use this for initialization
	void Start () {
        ui.transform.localScale += new Vector3(-0.5F, -0.5F, -0.5F);
        //transform.Rotate(Vector3.back * Time.deltaTime * degreesPerSecond);
    }

    // Update is called once per frame
    void Update () {
		
	}
}

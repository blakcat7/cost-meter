using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour {
    public Transform from;
    public Transform to;
    public float speed = 0.1F;
    private Vector3 currentAngle;

    // Use this for initialization
    void Start () {
        currentAngle = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update () {
        //currentAngle = new Vector3(currentAngle.x, currentAngle.y, currentAngle.z);
        //transform.rotation = Quaternion.Lerp(new Vector3(currentAngle.x,currentAngle.y,currentAngle.z), to.rotation, Time.time * speed);
    }
}

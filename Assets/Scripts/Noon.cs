using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noon : MonoBehaviour
{
    public float rotationSpeed = 1;
    public float sAngle;
    public float eAngle;

    //Take A - SmoothingDamping between two vectors
    //public float rotationLength = 10;
    //public Vector3 startAngle;
    //public Vector3 endAngle;
    //Vector3 curVel = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //Take A - SmoothingDamping between two vectors 
        //this.transform.eulerAngles = startAngle;

        //Take B rotate around the axis. Worked as Intended
        Vector3 angle = this.transform.eulerAngles;
        angle.z = sAngle;
        this.transform.eulerAngles = angle;
    }

    // Update is called once per frame
    void Update()
    {
        //Take A - SmoothingDamping between two vectors 
        //this.transform.eulerAngles = Vector3.SmoothDamp(this.transform.eulerAngles, endAngle, ref curVel, rotationSpeed);

        //Take B rotate around the axis. Worked as Intended
        Vector3 tempAngle = this.transform.eulerAngles;
        //Same thing
        tempAngle.z = tempAngle.z + rotationSpeed * Time.deltaTime;
        //tempAngle.z +- rotationSpeed;
        this.transform.eulerAngles = tempAngle;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public HingeJoint2D joint;
    public float rotatePower;
    public float maxRotation;
    bool rotateLeft;

    // Start is called before the first frame update
    void Start()
    {
        /*
        JointMotor2D motor = joint.motor;
        motor.motorSpeed = -rotatePower;
        joint.motor = motor;
        rotateLeft = true;
        */
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Debug.Log(transform.eulerAngles.z);
        //Debug.Log("Rotation is okay");
        //Debug.Log(transform.eulerAngles.z);
        if (transform.eulerAngles.z > maxRotation)
        {
            Debug.Log("Rotation is too much!");
            //joint.motor.motorSpeed = -rotatePower;
            //joint.motorSpeed = rotatePower;
            JointMotor2D motor = joint.motor;
            motor.motorSpeed = rotatePower;
            joint.motor = motor;
            //rotateLeft=false;
        }
        if(transform.eulerAngles.z < 360 && transform.eulerAngles.z > 200 )
        {
            //Debug.Log(transform.eulerAngles.z);
            Debug.Log("Rotation is not enough!");
            JointMotor2D motor = joint.motor;
            motor.motorSpeed = -rotatePower;
            joint.motor = motor;
            rotateLeft=true;
        }
        */
    }

    private void FixedUpdate()
    {
        //Debug.Log(transform.rotation.z);
        //Debug.Log(transform.eulerAngles.z);
        float x = UnityEngine.Random.Range(0f, 1f);
        if(x > 0.95f)
        {
            JointMotor2D motor = joint.motor;
            motor.motorSpeed = UnityEngine.Random.Range(-9f, 9f);
            joint.motor = motor;
        }
        
    }
}

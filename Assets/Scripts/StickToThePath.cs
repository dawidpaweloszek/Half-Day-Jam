using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;
public class StickToThePath : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] keyPoints;

    public float leftMotorSpeed;
    public float rightMotorSpeed;
    
    Transform targetTransform;
    bool isMotorRunning; 

    private void Start()
    {
        //targetTransform.position = keyPoints[0].transform.position;
    }

    private void Update()
    {
        var gamepad = (DualShockGamepad)Gamepad.all[0];
        if (isMotorRunning == true)
        {
            gamepad.SetMotorSpeeds(leftMotorSpeed, rightMotorSpeed);
        }
        else
        {
            gamepad.SetMotorSpeeds(0, 0);
        } 
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "KeyPoint")
        {
            isMotorRunning = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "KeyPoint")
        {
            isMotorRunning = false;
        }
    }
}

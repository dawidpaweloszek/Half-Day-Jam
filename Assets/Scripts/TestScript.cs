using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;

public class TestScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var gamepad = (DualShockGamepad)Gamepad.all[0];
        // Set light bar color 
        //gamepad.SetLightBarColor();

        // Try using vibrations
        //gamepad.SetMotorSpeeds(5, 5);
    }
}

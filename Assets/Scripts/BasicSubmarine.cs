using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;

public class BasicSubmarine : MonoBehaviour
{
    public Color idleColor;

    private void Awake()
    {
        var gamepad = (DualShockGamepad)Gamepad.all[0];
        gamepad.SetLightBarColor(idleColor);
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    // Set light bar color 
    //    //

    //    // Try using vibrations
    //    //gamepad.SetMotorSpeeds(5, 5);
    //}
}

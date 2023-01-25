using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;

public class Area : MonoBehaviour
{
    public Color areaColorEnter;
    public Color areaColorExit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Body")
        { 
            var gamepad = (DualShockGamepad)Gamepad.all[0];
            gamepad.SetLightBarColor(areaColorEnter);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Body")
        {
            var gamepad = (DualShockGamepad)Gamepad.all[0];
            gamepad.SetLightBarColor(areaColorExit);
        }
    }
}

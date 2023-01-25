using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;

public class BasicSubmarine : MonoBehaviour
{
    public Color idleColor;
    public Player input;
    public float speed;

    private void Awake()
    {
        var gamepad = (DualShockGamepad)Gamepad.all[0];
        gamepad.SetLightBarColor(idleColor);

        input = GetComponent<Player>();
    }

    private void FixedUpdate()
    {
        //Vector2 inputVector = input.Movement.Up&Down.ReadValue<Vector2>();
        //transform.position += new Vector3(inputVector.x, 0, inputVector.y) * Time.deltaTime * speed;
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

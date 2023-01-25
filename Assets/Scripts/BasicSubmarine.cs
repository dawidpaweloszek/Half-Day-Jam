using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;

public class BasicSubmarine : MonoBehaviour
{
    public Color idleColor;
    public float speed;
    public PlayerInput playerInput;
    public PlayerInputAction inputAction;

    private void Awake()
    {
        var gamepad = (DualShockGamepad)Gamepad.all[0];
        gamepad.SetLightBarColor(idleColor);

        playerInput = GetComponent<PlayerInput>();
        inputAction = new PlayerInputAction();

        inputAction.Movement.Enable();
    }

    private void FixedUpdate()
    {
        Vector2 inputVector = inputAction.Movement.Movement.ReadValue<Vector2>();
        //Debug.Log(inputVector);
        transform.position += new Vector3(inputVector.x, 0, inputVector.y) * Time.deltaTime * speed;
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

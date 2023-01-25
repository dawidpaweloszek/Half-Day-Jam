using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;

public class BasicSubmarine : MonoBehaviour
{
    public Color idleColor;
    public Color currentColor;
    public float speed;
    public PlayerInput playerInput;
    public PlayerInputAction inputAction;

    private void Awake()
    {
        var gamepad = (DualShockGamepad)Gamepad.all[0];
        currentColor = idleColor;
        //gamepad.SetMotorSpeeds(1.0f, 0.0f);

        playerInput = GetComponent<PlayerInput>();
        inputAction = new PlayerInputAction();

        inputAction.Movement.Enable();
    }

    private void FixedUpdate()
    {
        var gamepad = (DualShockGamepad)Gamepad.all[0];
        gamepad.SetLightBarColor(currentColor);

        Vector2 inputVector = inputAction.Movement.Movement.ReadValue<Vector2>();
        transform.position += new Vector3(inputVector.x, 0, inputVector.y) * Time.deltaTime * speed;
    }
}

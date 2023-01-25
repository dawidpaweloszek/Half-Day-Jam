using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.DualShock;

public class Emitter : MonoBehaviour
{
    public AudioSource source;

    private void OnTriggerEnter(Collider other)
    {
        source.Play();
    }

}

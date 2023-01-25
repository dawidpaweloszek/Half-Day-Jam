using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emitter : MonoBehaviour
{
    public AudioSource source;

    private void OnTriggerEnter(Collider other)
    {
        source.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        source.Play();
    }
}

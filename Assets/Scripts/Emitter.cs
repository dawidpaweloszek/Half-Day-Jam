using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;

public class Emitter : MonoBehaviour
{
    public AudioSource source;
    public BasicSubmarine player;
    public Color emitterColor;

    private void OnTriggerEnter(Collider other)
    {
        source.Play();
        player = GameObject.Find("Camera").GetComponent<BasicSubmarine>();
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        Color tmp = player.currentColor;
        player.currentColor = emitterColor;
        yield return new WaitForSeconds(1.0f);
        player.currentColor = tmp;
    }
}

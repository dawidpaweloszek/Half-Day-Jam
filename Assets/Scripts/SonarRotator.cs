using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarRotator : MonoBehaviour
{
    public float angle;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, angle * Time.deltaTime);
    }
}

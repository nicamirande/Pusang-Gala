using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdRotate : MonoBehaviour
{
    public float rotationSpeed = 45f; // Adjust the rotation speed as needed

    void Update()
    {
        // Rotate around the y-axis based on the time passed since the last frame
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
    }
}

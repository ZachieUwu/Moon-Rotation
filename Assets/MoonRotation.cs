using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MoonRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private Transform rotateAround;

    private bool rotateClockwise = true;

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetMouseButtonDown(0))
        {
            ReverseRotate();
        }

        float direction = rotateClockwise ? 1f : -1f;
        transform.RotateAround(rotateAround.position, Vector3.forward, direction * rotationSpeed * Time.deltaTime);
    }

    private void ReverseRotate()
    {
        rotateClockwise = !rotateClockwise;
    }
}

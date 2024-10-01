using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool moveLeft = false;

    // Update is called once per frame
    void Update()
    {
        // Move the obstacle in the chosen direction
        if (moveLeft)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

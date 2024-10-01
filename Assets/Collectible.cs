using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int scoreValue = 10;
    public bool isPowerUp = false;
    private GameManager gameManager;
    private MoonRotation circle;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        circle = FindObjectOfType<MoonRotation>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AddScore(scoreValue);

            if (isPowerUp)
            {
                circle.IncreaseSpeed(10f);
            }

            Destroy(gameObject);
        }
    }
}


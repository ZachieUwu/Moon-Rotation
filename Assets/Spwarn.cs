using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwarn : MonoBehaviour
{
    public GameObject[] Obstacles;

    public Transform LeftSpawner;
    public Transform RightSpawner;

    public float RandomYOffsetMinimum = 0f;
    public float RandomYOffsetMaximum = 6f;

    [Header("Timer Delay")]
    [SerializeField] private float spawnDelay;

    private int randomIndex;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawns", 3, spawnDelay);
    }

    void Spawns()
    { 
        int randomChance = Random.Range(0, Obstacles.Length);
        float randomSpawner = Random.value;
        float randomYOffset = Random.Range(RandomYOffsetMinimum, RandomYOffsetMaximum);

        GameObject spawnedObstacle;

        if (randomSpawner > 0.5f)
        {
            spawnedObstacle = Instantiate(Obstacles[randomChance],
                                          new Vector3(LeftSpawner.position.x, randomYOffset, LeftSpawner.position.z),
                                          LeftSpawner.rotation);
            spawnedObstacle.GetComponent<ObstacleMovement>().moveLeft = false;
        }
        else
        {
            spawnedObstacle = Instantiate(Obstacles[randomChance],
                                          new Vector3(RightSpawner.position.x, randomYOffset, RightSpawner.position.z),
                                          RightSpawner.rotation);
            spawnedObstacle.GetComponent<ObstacleMovement>().moveLeft = true;
        }
    }

}

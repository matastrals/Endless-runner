using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UIElements;
using Unity.Mathematics;

public class SpawnObstacleAir : MonoBehaviour
{
    public GameObject Obstacle;
    private float timer = 0;
    private float spawnInterval = 3f;

    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= spawnInterval)
        {
            Vector2 coordinate = new Vector2(13f, 5.5f);
            Instantiate(Obstacle, coordinate, Quaternion.identity);
            timer = 0;
            spawnInterval = UnityEngine.Random.Range(6f, 15f);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UIElements;
using Unity.Mathematics;

public class SpawnFallObstacle : MonoBehaviour
{
    public GameObject Obstacle;
    private float timer = 0;
    private float spawnInterval = 10f;

    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= spawnInterval)
        {
            Vector2 coordinate = new Vector2(-6, 7);
            Instantiate(Obstacle, coordinate, Quaternion.identity);
            timer = 0;
            spawnInterval = UnityEngine.Random.Range(15f, 30f);
        }
    }
}


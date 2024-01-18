using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovementAir : MonoBehaviour
{
    private float moveSpeed = 0.5f;
    public GameObject Obstacle;
    void Update()
    {
        Obstacle.transform.Translate(new Vector2(-13f, -4.8f) * moveSpeed * Time.deltaTime);
    }
}

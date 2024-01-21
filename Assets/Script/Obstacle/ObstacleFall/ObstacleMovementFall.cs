using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovementFall : MonoBehaviour
{
    private float moveSpeed = 0.5f;
    public GameObject Obstacle;
    void Update()
    {
        Obstacle.transform.Translate(new Vector2(0, -6) * moveSpeed * Time.deltaTime);
    }
}

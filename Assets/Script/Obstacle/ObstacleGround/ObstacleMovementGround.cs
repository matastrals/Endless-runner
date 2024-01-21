using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private float moveSpeed = 0.5f;
    public GameObject Obstacle;
    static public Vector2 position;
    // Update is called once per frame
    void Update()
    {
        Obstacle.transform.Translate(new Vector2(-15f, 0f) * moveSpeed * Time.deltaTime);
        position = Obstacle.transform.position;
    }

    public float MoveSpeed
    {
        get { return moveSpeed; }
        set { moveSpeed = value; }
    }



}       

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float moveSpeed = 0.5f;
    public GameObject Obstacle;
    // Update is called once per frame
    void Update()
    {
        Obstacle.transform.Translate(new Vector2(-15f, 0f) * moveSpeed * Time.deltaTime);
    }
}       

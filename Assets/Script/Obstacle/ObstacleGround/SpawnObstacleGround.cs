using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UIElements;

public class SpawnObstacleGround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public GameObject Obstacle;
    private float timer = 0;

    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= 2)
        {
            Vector2 coordinate = new Vector2(13.3f, -3.6f);
            Instantiate(Obstacle, coordinate, Quaternion.identity);
            timer = 0;
        }
    }
}


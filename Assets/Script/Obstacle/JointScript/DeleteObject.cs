using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 positionObstacle = transform.position;
        if (positionObstacle.x <= -15)
        {
            Destroy(gameObject);
        }
    }
}

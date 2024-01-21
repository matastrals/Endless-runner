using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObjectOF : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 positionOF = transform.position;
        if (positionOF.y <= -10)
        {
            Destroy(gameObject);
        }
    }
}

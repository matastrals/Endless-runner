using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 2, ForceMode2D.Impulse);
        }

    }
}

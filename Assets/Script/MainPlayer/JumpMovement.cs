using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class JumpMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 jump = new Vector2(0, 6);
    private float ground = -3.3f;
    private bool canDoubleJump = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (transform.position.y <= ground)
            {
                rb.velocity = jump;
                canDoubleJump = true;
            }
            else if (canDoubleJump)
            {
                rb.velocity = new Vector2(0, 6);
                canDoubleJump = false; 
            }
        }
    }
}

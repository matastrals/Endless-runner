using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour
{
    private float countTime;
    public ObstacleMovement obstacleMovement;
    void Update()
    {
        countTime += Time.deltaTime;
        if (countTime >= 5)
        {
            float currentSpeed = obstacleMovement.MoveSpeed;
            obstacleMovement.MoveSpeed = currentSpeed + 0.05f;
            countTime = 0;
            print(currentSpeed);

        }
    }
}

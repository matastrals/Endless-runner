using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IsCollide : MonoBehaviour
{
    private void Start()
    {
        MainPlayer = GameObject.FindWithTag("Player");
    }

    private GameObject MainPlayer;
    private void OnTriggerEnter2D(Collider2D MainPlayer)
    {
        SceneManager.LoadScene("GameOver");
    }

}

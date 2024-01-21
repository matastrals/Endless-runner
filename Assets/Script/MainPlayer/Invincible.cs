using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Invincible : MonoBehaviour
{
    public BoxCollider2D myCollider;
    public Rigidbody2D myRigidbody;
    private float cooldownDuration = 5;
    private bool isSpellReady = true;

    void Start()
    {

    }

    void Update()
    {
        if (isSpellReady && Input.GetKeyDown(KeyCode.E))
        {
            StartInvincibility();
        }
    }

    void StartInvincibility()
    {
        isSpellReady = false;
        StartCoroutine(InvincibleCoroutine());
        
    }

    IEnumerator CooldownCoroutine(float cooldown)
    {
        print("I am in cooldown");
        yield return new WaitForSeconds(cooldown);
        isSpellReady = true;
    }

    IEnumerator InvincibleCoroutine()
    {
        myCollider.enabled = false;
        myRigidbody.constraints = RigidbodyConstraints2D.FreezePosition;
        yield return new WaitForSeconds(3);
        print("C'est finit");
        myCollider.enabled = true;
        myRigidbody.constraints = RigidbodyConstraints2D.None;
        StartCoroutine(CooldownCoroutine(cooldownDuration));
    }

}

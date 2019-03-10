using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameManager gameManager;
    public float hurtDelay = 2f;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Enemy")
        {
            Invoke("Hurt", hurtDelay);
        }
    }

    void Hurt()
    {
        LivesScript.health -= 1;
    }

}

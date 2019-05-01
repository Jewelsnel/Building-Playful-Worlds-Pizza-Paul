using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameManager gameManager;
    public float hurtDelay = 2f;

    public AudioClip PainClip;
    public AudioSource Pain;


    void OnCollisionEnter(Collision collisionInfo)
    {

        Pain.clip = PainClip;

        if (collisionInfo.collider.name == "Car")
        {
            Invoke("Hurt", hurtDelay);
        }
    }

    void Hurt()
    {
        LivesScript.health -= 1;
        Pain.Play();
    }

}

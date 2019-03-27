using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    public float speed = 100f;
    public float pizzaLife = 2f;

    private float pizzaTimer;

    void Start()
    {
        pizzaTimer = pizzaLife;
    }


    void FixedUpdate()
    {

        transform.position += transform.forward * speed * Time.deltaTime;

        pizzaTimer -= Time.deltaTime;
        if (pizzaTimer <- 0f)
        {
            Destroy (gameObject);
        }
    }
  
}


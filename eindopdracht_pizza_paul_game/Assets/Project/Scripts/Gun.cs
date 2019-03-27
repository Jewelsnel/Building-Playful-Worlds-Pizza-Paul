using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 50f;
    public GameObject pizza;

    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            PizzaShot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {

           Townspeople tPeople = hit.transform.GetComponent<Townspeople>();
            if (tPeople != null)
            {
                tPeople.TakeDamage(damage);
            }
        }
    }

    void PizzaShot()
    {
        GameObject pizzaObject = Instantiate(pizza);
        pizzaObject.transform.position = fpsCam.transform.position;
        pizzaObject.transform.forward = fpsCam.transform.forward;
    }
    
}

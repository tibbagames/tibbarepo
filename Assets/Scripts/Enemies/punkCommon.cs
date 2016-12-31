using UnityEngine;
using System.Collections;

public class punkCommon : Enemy {

    float bulletDamage = 20;
    float granadeDamage = 50;   

    void OnTriggerEnter2D(Collider2D Collider)
    {
        if (Collider.gameObject.tag == "Bullet")
        {
            Destroy(Collider.gameObject);
            decreaseLife(bulletDamage);                      
        }

        if (Collider.gameObject.tag == "Granade")
        {
            float proximity = (Collider.gameObject.GetComponent<Transform>().position - transform.position).magnitude;
            float effect = 1 - (proximity / 2);
            decreaseLife(granadeDamage * effect);
        }
    }   
}


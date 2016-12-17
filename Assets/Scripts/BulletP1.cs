using UnityEngine;
using System.Collections;

public class BulletP1 : MonoBehaviour {
    
    public int speed;
    public GameObject bulletLightPrefabP1;
    GameObject bulletLightP1;


    void Start()
    {        
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,speed);
        //bulletLightP1 = Instantiate(bulletLightPrefabP1, new Vector3(Player1Control.finalPosition.x, -3.6f, -1), GetComponent<Transform>().rotation) as GameObject;
    }    

    void OnTriggerEnter2D()
    {
        //Destroy(gameObject);
        //Destroy(bulletLightP1);
    }

    void OnBecameInvisible()
    {        
        Destroy(gameObject);
        //Destroy(bulletLightP1);
    }
}

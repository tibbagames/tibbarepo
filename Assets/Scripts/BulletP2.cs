using UnityEngine;
using System.Collections;

public class BulletP2 : MonoBehaviour {

    public int speed;
    public GameObject bulletLightPrefabP2;
    GameObject bulletLightP2;


    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        //bulletLightP2 = Instantiate(bulletLightPrefabP2, new Vector3(Player2Control.finalPosition.x, -3.6f, -1), GetComponent<Transform>().rotation) as GameObject;
    }

    void OnTriggerEnter2D()
    {
        Destroy(gameObject);
        //Destroy(bulletLightP2);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
        //Destroy(bulletLightP2);
    }
}

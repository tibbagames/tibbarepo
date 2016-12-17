using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {
    //Maneja la sacudida de la camera
    public float camShakeAmount = 0.00002f;
    CameraShake camShake;

    void Start()
    {       
        camShake = GetComponent<CameraShake>();
        camShake.Shake(camShakeAmount, 0.2f);
    }   

    public void destroyExplosionPrefab()
    {
        Destroy(gameObject);        
    }    
}

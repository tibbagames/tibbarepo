using UnityEngine;
using System.Collections;

public class rifleFire : MonoBehaviour {
    public void followPlayer()
    {
        this.GetComponent<Transform>().position = Player1Control.finalPosition;
    }
    
    public void destroyRifleFirePrefab()
    {        
        Destroy(gameObject);
    }
}

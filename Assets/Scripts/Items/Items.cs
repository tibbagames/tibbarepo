using UnityEngine;
using System.Collections;

public class Items : MonoBehaviour {
    protected float life = 100;
	
    public void decreaseLife(float damage)
    {
        life -= damage;
    }
}

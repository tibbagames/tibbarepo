using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    protected float life = 100;
    bool isDead = false;

    void FixedUpdate()
    {
        if (life <= 0)
        {            
            isDead = true;
        }
    }

    public void decreaseLife(float damage)
    {
        life -= damage;
    }

    public bool isEnemyDead()
    {
        return isDead;
    }   
}

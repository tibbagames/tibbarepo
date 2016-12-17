﻿using UnityEngine;
using System.Collections;

public class Item_woodBox : Items
{
	public GameObject explosionPrefab1;

	float originalY;
	float explosionDelay = 0.3f;
	bool explodeFirstOnce = false;
	enum States { New, Partial, Destroyed };
	States item_state = States.New;
	SpriteRenderer rndr;
	Sprite New;
	Sprite Partial;
	Sprite Destroyed;
	Sprite HitNew;
	Sprite HitPartial;    
	GameObject explosion1;
    int granadeDamage = 40;
    int bulletDamage = 5;

	void Start()
	{
		Sprite[] spriteSheet = Resources.LoadAll<Sprite>("Items/woodBoxSP");
		originalY = this.transform.position.y;
		New = spriteSheet[0];
		Partial = spriteSheet[1];
		Destroyed = spriteSheet[2];
		HitNew = spriteSheet[3];
		HitPartial = spriteSheet[4];                
		rndr = GetComponent<SpriteRenderer>();
		rndr.sprite = New;
	}

	void Update() 
	{        
		if (item_state == States.Destroyed) 
		{
			if (!explodeFirstOnce) {
				explosion1 = Instantiate (explosionPrefab1, new Vector2 (this.transform.position.x, this.transform.position.y), GetComponent<Transform> ().rotation) as GameObject;
				explodeFirstOnce = true;
			}
			if (explosionDelay < 0) {
			} else {
				explosionDelay -= Time.deltaTime;
				this.transform.position = new Vector2 (this.transform.position.x, this.transform.position.y + (5f * Time.deltaTime));
			}					
		}
		if (this.transform.position.y > originalY) {
			this.transform.position = new Vector2 (this.transform.position.x, this.transform.position.y - (7f * Time.deltaTime));
		} else {
			this.transform.position = new Vector2 (this.transform.position.x, originalY);		
		}
	}

	void FixedUpdate()
	{
		if (life >= 50) {
			rndr.sprite = New;
			item_state = States.New;
		}
		if (life < 50) 
		{
			rndr.sprite = Partial;
			item_state = States.Partial;
		}
		if (life < 0) 
		{
			rndr.sprite = Destroyed;	
			item_state = States.Destroyed;
		}
	}

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
            Debug.Log(effect);
        }
        switch (item_state) 
		{
		case States.New:                
                rndr.sprite = HitNew;            
            break;
		case States.Partial:                
                rndr.sprite = HitPartial;            
            break;
		case States.Destroyed:			
			break;
		}
	}
}
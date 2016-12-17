using UnityEngine;
using System.Collections;

public class Item_tiresA : Items
{	
	enum States { New, Partial, Destroyed };
	States item_state = States.New;
	SpriteRenderer rndr;
	Sprite New;
	Sprite Partial;
	Sprite Destroyed;
	Sprite HitNew;
	Sprite HitPartial;
    int bulletDamage = 5;
    int granadeDamage = 40;  

	void Start()
	{
		Sprite[] spriteSheet = Resources.LoadAll<Sprite>("Items/tiresASP");
		New = spriteSheet[0];
		Partial = spriteSheet[1];
		Destroyed = spriteSheet[2];
		HitNew = spriteSheet[3];
		HitPartial = spriteSheet[4];                
		rndr = GetComponent<SpriteRenderer>();
		rndr.sprite = New;
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
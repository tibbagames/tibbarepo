using UnityEngine;
using System.Collections;

public class Player1Control : MonoBehaviour {
	public float maxSpeed = 7f;
	public string HorizontalCtrlPAD1 = "Horizontal_PADP1";
	public string HorizontalCtrlPAD2 = "Horizontal_PADP2";
    public float fireDelay;
    public GameObject bulletPrefab;    
    public GameObject crosshairPrefab;
    public GameObject granadePrefab;
    public GameObject explosionPrefab;
    public GameObject rifleFirePrefab;
    public float granadeArcHeight = 1f;
    public static Vector2 finalPosition;
    public static int selectedController;
    Vector3 granadeStartPos;    
    GameObject granade;
    GameObject crosshair;
    GameObject explosion;
    GameObject rifleFire;        

    string[] controllers;
	
    float parabola = 0;
	float move;
	bool goingRight = false;
    Vector3 posP1;
    Vector3 CrossHairPosition;
    float playerBoundaryRadius = 0.5f;
    float cooldownTimerFire1 = 0;
    float newposP1;

    const int STATE_IDLE = 0;
	const int STATE_RUN = 1;
	const int STATE_DUCK = 2;
	const int STATE_TGRAN = 3;
	const int STATE_DEAD = 4;
	const int STATE_WIN = 5;    
    const int STATE_HGRAN = 7;

    int _currentAnimationState = STATE_IDLE;

	Rigidbody2D rigidBody2D;
	Animator animator;

	// Use this for initialization
	void Start () {
		rigidBody2D = GetComponent<Rigidbody2D> (); 
		animator = GetComponent<Animator> ();
		selectedController = Constants.KEYBOARD_CONTROL;
	}

	// Update is called once per frame
	void Update()
	{        
        posP1 = GetComponent<Transform>().position;

        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        if (posP1.x + playerBoundaryRadius > widthOrtho)
        {
            posP1.x = widthOrtho - playerBoundaryRadius;
        }
        if (posP1.x - playerBoundaryRadius < -widthOrtho)
        {
            posP1.x = -widthOrtho + playerBoundaryRadius;
        }
        GetComponent<Transform>().position = posP1;
        if (goingRight)
        {           
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {            
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        switch (selectedController)
        {
            case Constants.PAD_CONTROL_PIONE:
                cooldownTimerFire1 -= Time.deltaTime;
                if (Input.GetButton("Fire1_PAD1") && cooldownTimerFire1 <= 0)
                {
                    if (_currentAnimationState != STATE_DEAD && _currentAnimationState != STATE_DUCK && _currentAnimationState != STATE_TGRAN && _currentAnimationState != STATE_HGRAN && _currentAnimationState != STATE_WIN)
                    {
                        cooldownTimerFire1 = fireDelay;
                        if (goingRight)
                        {
                            newposP1 = posP1.x - 0.25f;
                        }
                        else if (!goingRight)
                        {
                            newposP1 = posP1.x + 0.25f;
                        }
                        Instantiate(bulletPrefab, new Vector2(newposP1, -3.0f), GetComponent<Transform>().rotation);
                        rifleFire = Instantiate(rifleFirePrefab, new Vector2(newposP1, -3.2f), GetComponent<Transform>().rotation) as GameObject;
                    }
                }
                if (Input.GetButtonDown("Fire2_PAD1"))
                {                    
                    if (_currentAnimationState != STATE_DEAD && _currentAnimationState != STATE_DUCK && _currentAnimationState != STATE_WIN)
                    {                        
                        crosshair = Instantiate(crosshairPrefab, new Vector2(posP1.x, -2.5f), GetComponent<Transform>().rotation) as GameObject;
                        this.rigidBody2D.velocity = new Vector2(0, this.GetComponent<Rigidbody2D>().velocity.y);
                        changeState(STATE_HGRAN);
                    }
                    Debug.Log(_currentAnimationState);
                }
                if (Input.GetButtonUp("Fire2_PAD1"))
                {                    
                    CrossHairPosition = crosshair.transform.position;
                    if (goingRight)
                    {
                        granade = Instantiate(granadePrefab, new Vector2(posP1.x + 0.5f, -3.0f), GetComponent<Transform>().rotation) as GameObject;
                        granadeStartPos = new Vector3(posP1.x + 0.5f, -3.0f, 0);
                    }
                    else
                    {
                        granade = Instantiate(granadePrefab, new Vector2(posP1.x - 0.5f, -3.0f), GetComponent<Transform>().rotation) as GameObject;
                        granadeStartPos = new Vector3(posP1.x - 0.5f, -3.0f, 0);
                    }
                    Destroy(crosshair);
                    changeState(STATE_TGRAN);
                }
                break;
            case Constants.PAD_CONTROL_PITWO:
                cooldownTimerFire1 -= Time.deltaTime;
                if (Input.GetButton("Fire1_PAD2") && cooldownTimerFire1 <= 0)
                {
                    if (_currentAnimationState != STATE_DEAD && _currentAnimationState != STATE_DUCK && _currentAnimationState != STATE_TGRAN && _currentAnimationState != STATE_HGRAN && _currentAnimationState != STATE_WIN)
                    {
                        cooldownTimerFire1 = fireDelay;
                        if (goingRight)
                        {
                            newposP1 = posP1.x - 0.25f;
                        }
                        else if (!goingRight)
                        {
                            newposP1 = posP1.x + 0.25f;
                        }
                        Instantiate(bulletPrefab, new Vector2(newposP1, -3.0f), GetComponent<Transform>().rotation);
                        rifleFire = Instantiate(rifleFirePrefab, new Vector2(newposP1, -3.2f), GetComponent<Transform>().rotation) as GameObject;
                    }
                }
                if (Input.GetButtonDown("Fire2_PAD2"))
                {                    
                    if (_currentAnimationState != STATE_DEAD && _currentAnimationState != STATE_DUCK && _currentAnimationState != STATE_WIN)
                    {
                        crosshair = Instantiate(crosshairPrefab, new Vector2(posP1.x, -2.5f), GetComponent<Transform>().rotation) as GameObject;
                        this.rigidBody2D.velocity = new Vector2(0, this.GetComponent<Rigidbody2D>().velocity.y);
                        changeState(STATE_HGRAN);
                    }
                }
                if (Input.GetButtonUp("Fire2_PAD2"))
                {
                    CrossHairPosition = crosshair.transform.position;
                    if (goingRight)
                    {
                        granade = Instantiate(granadePrefab, new Vector2(posP1.x + 0.5f, -3.0f), GetComponent<Transform>().rotation) as GameObject;
                        granadeStartPos = new Vector3(posP1.x + 0.5f, -3.0f, 0);
                    }
                    else
                    {
                        granade = Instantiate(granadePrefab, new Vector2(posP1.x - 0.5f, -3.0f), GetComponent<Transform>().rotation) as GameObject;
                        granadeStartPos = new Vector3(posP1.x - 0.5f, -3.0f, 0);
                    }
                    Destroy(crosshair);
                    changeState(STATE_TGRAN);
                }
                break;
            case Constants.KEYBOARD_CONTROL:                
                cooldownTimerFire1 -= Time.deltaTime;                          
                if (Input.GetButton("Fire1_Keyboard") && cooldownTimerFire1 <= 0)
                {
                    if(_currentAnimationState != STATE_DEAD && _currentAnimationState != STATE_DUCK && _currentAnimationState != STATE_TGRAN && _currentAnimationState != STATE_HGRAN && _currentAnimationState != STATE_WIN)
                    {
                        cooldownTimerFire1 = fireDelay;
                        if (goingRight)
                        {
                            newposP1 = posP1.x - 0.25f;
                        }
                        else if (!goingRight)
                        {
                            newposP1 = posP1.x + 0.25f;
                        }
                        Instantiate(bulletPrefab, new Vector2(newposP1, -3.0f), GetComponent<Transform>().rotation);
                        rifleFire = Instantiate(rifleFirePrefab, new Vector2(newposP1, -3.2f), GetComponent<Transform>().rotation) as GameObject;                        
                    }
                }
                if (Input.GetButtonDown("Fire2_Keyboard"))
                {
                    if (_currentAnimationState != STATE_DEAD && _currentAnimationState != STATE_DUCK && _currentAnimationState != STATE_WIN)
                    {                        
                        crosshair = Instantiate(crosshairPrefab, new Vector2(posP1.x, -2.5f), GetComponent<Transform>().rotation) as GameObject;                        
                        this.rigidBody2D.velocity = new Vector2(0, this.GetComponent<Rigidbody2D>().velocity.y);
                        changeState(STATE_HGRAN);
                    }
                }
                if (Input.GetButtonUp("Fire2_Keyboard"))
                {
                    CrossHairPosition = crosshair.transform.position;
                    if (goingRight)
                    {
                        granade = Instantiate(granadePrefab, new Vector2(posP1.x + 0.5f, -3.0f), GetComponent<Transform>().rotation) as GameObject;
                        granadeStartPos = new Vector3(posP1.x + 0.5f, -3.0f, 0);
                    }
                    else
                    {
                        granade = Instantiate(granadePrefab, new Vector2(posP1.x - 0.5f, -3.0f), GetComponent<Transform>().rotation) as GameObject;
                        granadeStartPos = new Vector3(posP1.x - 0.5f, -3.0f, 0);
                    }
                    Destroy(crosshair);
                    changeState(STATE_TGRAN);                    
                }                
                break;
        }
        if (granade != null)
        {
            float x0 = granadeStartPos.x;
            float x1 = CrossHairPosition.x;
            float dist = x1 - x0;
            float nextX = Mathf.MoveTowards(granade.transform.position.x, x1, 10 * Time.deltaTime);
            float baseY = Mathf.Lerp(granadeStartPos.y, CrossHairPosition.y, (nextX - x0) / dist);
            float arc = granadeArcHeight * (nextX - x0) * (nextX - x1) / (-0.25f * dist * dist);
            Vector3 nextPos = new Vector3(nextX, baseY + arc, transform.position.z);

            // Rotate to face the next position, and then move there
            granade.transform.rotation = LookAt2D(nextPos - granade.transform.position);
            granade.transform.position = nextPos;

            if (granade.transform.position == CrossHairPosition)
            {
                explosion = Instantiate(explosionPrefab, granade.transform.position, GetComponent<Transform>().rotation) as GameObject;
                Destroy(granade);
            }
        }
    }

	void FixedUpdate () {
        if (goingRight)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        switch (selectedController) {
		case Constants.PAD_CONTROL_PIONE:
                if (_currentAnimationState != STATE_HGRAN && _currentAnimationState != STATE_TGRAN)
                {
                    move = Input.GetAxis(HorizontalCtrlPAD1);
                    if (move > 0.5)
                    {
                        goingRight = false;
                        this.rigidBody2D.velocity = new Vector2(move * maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
                        changeState(STATE_RUN);
                    }
                    else if (move < -0.5)
                    {
                        goingRight = true;
                        this.rigidBody2D.velocity = new Vector2(move * maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
                        changeState(STATE_RUN);
                    }
                    else if (move > -0.5 && move < 0.5)
                    {
                        this.rigidBody2D.velocity = new Vector2(0, this.GetComponent<Rigidbody2D>().velocity.y);
                        animator.StopPlayback();
                        changeState(STATE_IDLE);
                    }
                }
                else if (_currentAnimationState == STATE_HGRAN)
                {
                    if (crosshair.GetComponent<Player1Crosshair>().getPosition().x > this.GetComponent<Rigidbody2D>().position.x)
                    {
                        goingRight = false;
                    }
                    else if (crosshair.GetComponent<Rigidbody2D>().position.x < this.GetComponent<Rigidbody2D>().position.x)
                    {
                        goingRight = true;
                    }
                }
                break;
		case Constants.PAD_CONTROL_PITWO:
                if (_currentAnimationState != STATE_HGRAN && _currentAnimationState != STATE_TGRAN)
                {
                    move = Input.GetAxis(HorizontalCtrlPAD2);
                    if (move > 0.5)
                    {
                        goingRight = false;
                        this.rigidBody2D.velocity = new Vector2(move * maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
                        changeState(STATE_RUN);
                    }
                    else if (move < -0.5)
                    {
                        goingRight = true;
                        this.rigidBody2D.velocity = new Vector2(move * maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
                        changeState(STATE_RUN);
                    }
                    else if (move > -0.5 && move < 0.5)
                    {
                        this.rigidBody2D.velocity = new Vector2(0, this.GetComponent<Rigidbody2D>().velocity.y);
                        animator.StopPlayback();
                        changeState(STATE_IDLE);
                    }
                }
                else if (_currentAnimationState == STATE_HGRAN)
                {
                    if (crosshair.GetComponent<Player1Crosshair>().getPosition().x > this.GetComponent<Rigidbody2D>().position.x)
                    {
                        goingRight = false;
                    }
                    else if (crosshair.GetComponent<Rigidbody2D>().position.x < this.GetComponent<Rigidbody2D>().position.x)
                    {
                        goingRight = true;
                    }
                }
                break;
		case Constants.KEYBOARD_CONTROL:                
                if (_currentAnimationState != STATE_HGRAN && _currentAnimationState != STATE_TGRAN)
                {
                    if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftAlt))
                    {
                        goingRight = false;
                        this.rigidBody2D.velocity = new Vector2(1 * maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);                        
                        changeState(STATE_RUN);
                    }
                    else if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftAlt))
                    {
                        goingRight = true;
                        this.rigidBody2D.velocity = new Vector2(-1 * maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);                        
                        changeState(STATE_RUN);
                    }
                    else if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftAlt))
                    {
                        this.rigidBody2D.velocity = new Vector2(0, this.GetComponent<Rigidbody2D>().velocity.y);
                        changeState(STATE_DUCK);
                    }
                    else if (!Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
                    {
                        this.rigidBody2D.velocity = new Vector2(0, this.GetComponent<Rigidbody2D>().velocity.y);
                        changeState(STATE_IDLE);
                    }
                }
                else if (_currentAnimationState == STATE_HGRAN)
                {                    
                    if (crosshair.GetComponent<Player1Crosshair>().getPosition().x > this.GetComponent<Rigidbody2D>().position.x)
                    {
                        goingRight = false;                             
                    }else if(crosshair.GetComponent<Rigidbody2D>().position.x < this.GetComponent<Rigidbody2D>().position.x)
                    {
                        goingRight = true;
                    }
                }
                break;	
		}
        if (goingRight)
        {
            finalPosition = new Vector2(this.GetComponent<Transform>().position.x - 0.25f, -3.2f);            
        }
        else if (!goingRight)
        {
            finalPosition = new Vector2(this.GetComponent<Transform>().position.x + 0.25f, -3.2f);
        }
    }

	void changeState(int state){		
		if (_currentAnimationState == state)
			return;
		
		switch (state) {
			
		case STATE_RUN:
			animator.SetInteger ("state", STATE_RUN);
			break;		
		case STATE_IDLE:
			animator.SetInteger ("state", STATE_IDLE);
			break;
		case STATE_DUCK:
			animator.SetInteger ("state", STATE_DUCK);
			break;
        case STATE_HGRAN:
            animator.SetInteger("state", STATE_HGRAN);
            break;
        case STATE_TGRAN:           
           animator.SetInteger("state", STATE_TGRAN);            
           break;
        }
		_currentAnimationState = state;
	}

    // Animation Event (Windows Animation y seleccionar Player)
    public void changeBackIdle()
    {        
        changeState(STATE_IDLE);        
    }

    static Quaternion LookAt2D(Vector2 forward)
    {
        return Quaternion.Euler(0, 0, Mathf.Atan2(forward.y, forward.x) * Mathf.Rad2Deg);
    }
}
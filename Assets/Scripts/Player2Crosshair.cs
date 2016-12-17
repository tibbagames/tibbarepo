using UnityEngine;
using System.Collections;

public class Player2Crosshair : MonoBehaviour {
    public float moveSentivity = 0.20f;
    public string HorizontalCtrlPAD1 = "Horizontal_PADP1";
    public string HorizontalCtrlPAD2 = "Horizontal_PADP2";
    public string VerticalCtrlPAD1 = "Vertical_PADP1";
    public string VerticalCtrlPAD2 = "Vertical_PADP2";
    public float maxSpeed = 7f;
    float crossHairBoundaryRadius = 0.5f;
    float moveX;
    float moveY;
    Vector3 posP2;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        posP2 = GetComponent<Transform>().position;

        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        if (posP2.x + crossHairBoundaryRadius > widthOrtho)
        {
            posP2.x = widthOrtho - crossHairBoundaryRadius;
        }
        if (posP2.x - crossHairBoundaryRadius < -widthOrtho)
        {
            posP2.x = -widthOrtho + crossHairBoundaryRadius;
        }
        if (posP2.y > (Camera.main.orthographicSize - 1.8f))
        {
            posP2.y = Camera.main.orthographicSize - 1.8f;
        }
        if (posP2.y < (-Camera.main.orthographicSize + 2.5f))
        {
            posP2.y = -Camera.main.orthographicSize + 2.5f;
        }
        GetComponent<Transform>().position = posP2;
    }

    // Update is called once per frame
    void FixedUpdate()
    {        
        switch (Player2Control.selectedController)
        {
            case Constants.KEYBOARD_CONTROL:
                {                    
                    if (Input.GetKey(KeyCode.RightArrow))
                    {
                        this.GetComponent<Rigidbody2D>().position = new Vector2(this.GetComponent<Rigidbody2D>().position.x + moveSentivity, this.GetComponent<Rigidbody2D>().position.y);
                    }
                    else if (Input.GetKey(KeyCode.LeftArrow))
                    {
                        this.GetComponent<Rigidbody2D>().position = new Vector2(this.GetComponent<Rigidbody2D>().position.x - moveSentivity, this.GetComponent<Rigidbody2D>().position.y);
                    }
                    else if (Input.GetKey(KeyCode.UpArrow))
                    {
                        this.GetComponent<Rigidbody2D>().position = new Vector2(this.GetComponent<Rigidbody2D>().position.x, this.GetComponent<Rigidbody2D>().position.y + moveSentivity);
                    }
                    else if (Input.GetKey(KeyCode.DownArrow))
                    {
                        this.GetComponent<Rigidbody2D>().position = new Vector2(this.GetComponent<Rigidbody2D>().position.x, this.GetComponent<Rigidbody2D>().position.y - moveSentivity);
                    }
                    break;
                }
            case Constants.PAD_CONTROL_PIONE:
                {
                    moveX = Input.GetAxis(HorizontalCtrlPAD1);
                    moveY = Input.GetAxis(VerticalCtrlPAD1);
                    if (moveX > 0.5)
                    {
                        this.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
                    }
                    else if (moveX < -0.5)
                    {
                        this.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
                    }
                    else if (moveY > 0.5)
                    {
                        this.GetComponent<Rigidbody2D>().velocity = new Vector2(this.GetComponent<Rigidbody2D>().velocity.x, -moveY * maxSpeed);
                    }
                    else if (moveY < -0.5)
                    {
                        this.GetComponent<Rigidbody2D>().velocity = new Vector2(this.GetComponent<Rigidbody2D>().velocity.x, -moveY * maxSpeed);
                    }
                    if (moveX > -0.5 && moveX < 0.5)
                    {
                        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, this.GetComponent<Rigidbody2D>().velocity.y);
                    }
                    if (moveY > -0.5 && moveY < 0.5)
                    {
                        this.GetComponent<Rigidbody2D>().velocity = new Vector2(this.GetComponent<Rigidbody2D>().velocity.x, 0);
                    }
                    break;
                }
            case Constants.PAD_CONTROL_PITWO:
                {
                    moveX = Input.GetAxis(HorizontalCtrlPAD2);
                    moveY = Input.GetAxis(VerticalCtrlPAD2);
                    if (moveX > 0.5)
                    {
                        this.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
                    }
                    else if (moveX < -0.5)
                    {
                        this.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
                    }
                    else if (moveY > 0.5)
                    {
                        this.GetComponent<Rigidbody2D>().velocity = new Vector2(this.GetComponent<Rigidbody2D>().velocity.x, -moveY * maxSpeed);
                    }
                    else if (moveY < -0.5)
                    {
                        this.GetComponent<Rigidbody2D>().velocity = new Vector2(this.GetComponent<Rigidbody2D>().velocity.x, -moveY * maxSpeed);
                    }
                    if (moveX > -0.5 && moveX < 0.5)
                    {
                        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, this.GetComponent<Rigidbody2D>().velocity.y);
                    }
                    if (moveY > -0.5 && moveY < 0.5)
                    {
                        this.GetComponent<Rigidbody2D>().velocity = new Vector2(this.GetComponent<Rigidbody2D>().velocity.x, 0);
                    }
                    break;
                }
        }
    }

    public Vector2 getPosition()
    {
        return this.GetComponent<Rigidbody2D>().position;
    }
}

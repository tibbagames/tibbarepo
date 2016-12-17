using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    public Camera mainCam;
    float shakeAmount = 0;
    float offSetX;
    float offSetY;
    float prevOffSetX;
    float prevOffSetY;

    void Awake()
    {
        if (mainCam == null)
        {            
            mainCam = Camera.main;            
        }        
    }

    public void Shake(float amt, float lenght)
    {
        shakeAmount = amt;
        InvokeRepeating("BeginShake",0,0.01f);
        Invoke("StopShake", lenght);
    }

    void BeginShake()
    {        
        if (shakeAmount > 0)
        {
            Vector3 camPos = mainCam.transform.position;

            if (prevOffSetX > 0)
            {
                offSetX = Random.value * shakeAmount * 2 - shakeAmount;
                if (offSetX > 0)
                {
                    offSetX *= -1;
                }
            }
            else
            {
                offSetX = Random.value * shakeAmount * 2 - shakeAmount;
                if (offSetX < 0)
                {
                    offSetX *= -1;
                }
            }
            if (prevOffSetY > 0)
            {
                offSetY = Random.value * shakeAmount * 2 - shakeAmount;
                if (offSetY > 0)
                {
                    offSetY *= -1;
                }
            }
            else
            {
                offSetY = Random.value * shakeAmount * 2 - shakeAmount;
                if (offSetY < 0)
                {
                    offSetY *= -1;
                }
            }
                        
            if (offSetX > 0.05)
            {
                offSetX = 0.05f;
            }
            else
            {
                if (offSetX < -0.05)
                {
                    offSetX = -0.05f;
                }
            }

            if (offSetY > 0.05)
            {
                offSetY = 0.05f;
            }
            else
            {
                if (offSetY < -0.05)
                {
                    offSetY = -0.05f;
                }
            }


            prevOffSetX = offSetX;
            prevOffSetY = offSetY;
                        
            camPos.x += offSetX;
            camPos.y += offSetY;

            mainCam.transform.position = camPos;
        }
    }

    void StopShake()
    {
        CancelInvoke("BeginShake");
		mainCam.transform.position = new Vector3 (0, 0, -10);
    }
}

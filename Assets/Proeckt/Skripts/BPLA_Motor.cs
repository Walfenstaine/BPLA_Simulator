using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPLA_Motor : MonoBehaviour
{
    public Vint[] vint;
    public float forse = 30.0f;
    public Rigidbody rb;
    public Vector3 velositi;
    public float rut;
    public Animator anim;
    public bool ismotor;
    public GameObject cam;
    private bool ac;
    public void Cam_Enabled() 
    {
        ac = !ac;
        cam.SetActive(ac);
    }
    public void Starter()
    {
        if (ismotor)
        {
            vint[0].speed = 0;
            vint[1].speed = 0;
            ismotor = false;
        }
        else
        {
            vint[0].speed = 1000;
            vint[1].speed = 1000;
            ismotor = true;
        }
    }
    public void Muwe(Vector3 muve)
    {
        velositi = muve;
    }

    public void Rute(float rute) 
    {
        rut = rute;
    }
    private void FixedUpdate()
    {
        Camera.main.transform.LookAt(this.transform);
        if (ismotor) 
        {
            rb.AddForce(transform.up * velositi.y * forse);
            rb.AddForce(transform.forward * velositi.z * forse);
            rb.AddForce(transform.right * velositi.x * forse);
            rb.AddRelativeTorque(transform.up * rut * forse/5);
            if (velositi.z == 0)
            {
                anim.SetBool("Forvard", false);
                anim.SetBool("Back", false);
            }
            else
            {
                if (velositi.z > 0)
                {
                    anim.SetBool("Forvard", true);
                    anim.SetBool("Back", false);
                }
                if (velositi.z < 0)
                {
                    anim.SetBool("Forvard", false);
                    anim.SetBool("Back", true);
                }
            }


            if (velositi.x == 0)
            {
                anim.SetBool("Right", false);
                anim.SetBool("Left", false);
            }
            else
            {
                if (velositi.x > 0)
                {
                    anim.SetBool("Right", true);
                    anim.SetBool("Left", false);
                }
                if (velositi.x < 0)
                {
                    anim.SetBool("Right", false);
                    anim.SetBool("Left", true);
                }
            }
        }
        
    }
}

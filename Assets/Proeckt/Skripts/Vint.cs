using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vint : MonoBehaviour
{
    public float speed;
    private float rut;
    private void FixedUpdate()
    {
        if (rut <= 360)
        {
            rut += speed * Time.fixedDeltaTime;
        }
        else
        {
            rut = 0;
        }
        transform.localEulerAngles = new Vector3(0,rut,0);
    }
}

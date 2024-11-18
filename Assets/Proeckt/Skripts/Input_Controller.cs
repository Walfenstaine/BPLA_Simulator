using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Controller : MonoBehaviour
{
    public BPLA_Motor motor;
    public void Vertical(float vertical) 
    {
        motor.velositi.x = vertical;
    }
    public void Horizontal(float vertical)
    {
        motor.velositi.z = vertical;
    }
    public void Up(float vertical)
    {
        motor.velositi.y = vertical;
    }
    public void Rut(float vertical)
    {
        motor.rut = vertical;
    }
}

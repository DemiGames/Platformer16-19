using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderLogic : MonoBehaviour
{
    float speed;
    SliderJoint2D slider;
    private void Awake()
    {
        slider = gameObject.GetComponent<SliderJoint2D>();
        speed = slider.motor.motorSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SliderLimit"))
        {
            speed = -speed;
            var motor = slider.motor;
            motor.motorSpeed = speed;
            slider.motor = motor;
        }
    }
}

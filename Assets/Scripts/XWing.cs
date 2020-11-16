using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XWing : MonoBehaviour
{
    [Range(0, 100)]
    public float minSpeed;
    [Range(0, 1000)]
    public float maxSpeed;
    public float speed=0.1f;
    public float angularSpeed = 1;
    private float incSpeed = 0.1f;
    private float x,y;
    private void Awake()
    {
        speed = minSpeed;
    }
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.KeypadPlus))
        {
            Acelerar(1);
        }    
        else if (Input.GetKey(KeyCode.KeypadMinus))
        {
            Acelerar(-1);
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);


        transform.Rotate(y * angularSpeed * Time.deltaTime, x * angularSpeed * Time.deltaTime, 0);
    }

    void Acelerar(int mult)
    {
        speed += incSpeed * mult;
        speed = Mathf.Clamp(speed, minSpeed, maxSpeed);
    }
}

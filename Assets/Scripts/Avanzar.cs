using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avanzar : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.K)) speed = speed * -1;
    }
}

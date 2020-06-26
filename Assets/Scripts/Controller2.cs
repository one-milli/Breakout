using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            if (transform.position.z < 8)
            {
                transform.position += transform.forward * 0.15f;
            }
        }
        else if (Input.GetKey(KeyCode.J))
        {
            if (transform.position.z > -8)
            {
                transform.position -= transform.forward * 0.15f;
            }
        }
    }
}
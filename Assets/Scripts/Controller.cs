using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.z < 4)
            {
                transform.position += transform.forward * 0.2f;
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.z > -4)
            {
                transform.position -= transform.forward * 0.2f;
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hako_color : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    public float H = 0, S = 0;

    // Update is called once per frame
    public bool H_ = true;
    void Update()
    {
        for (int i = 1; i <= 4; i += 1)
        {
            GetComponent<Renderer>().material.color = UnityEngine.Color.HSVToRGB(H, 5, 100);
            if (H_)
            {
                H += (float)0.0005;
                if (H >= 1) H_ = false;
            }
            else
            {
                H -= (float)0.0005;
                if (H <= 0) H_ = true; 
            }
        }
        //S += 0.01f;
        //if (S >= 0.1f) S = 0.0f;
    }
}

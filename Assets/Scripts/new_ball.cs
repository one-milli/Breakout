using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class new_ball : MonoBehaviour
{
    public GameObject ball2;
    // Start is called before the first frame update
    public static int cnt = 0;
    void Start()
    {
        ball2.SetActive(false);
        cnt = 0;
    }

    void Update()
    {
        if (cnt == 600)
        {
            ball2.SetActive(true);
            transform.eulerAngles = new Vector3(0, Random.Range(30, 120), 0);
            gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
        }
        cnt++;
    }
}

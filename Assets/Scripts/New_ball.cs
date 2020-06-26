using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_ball : MonoBehaviour
{
    public bool LAUNCH=false;
    public float nowTime;
    public GameObject NewBall;
    // Start is called before the first frame update
    void Start()
    {
        nowTime = 0;
        NewBall.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        nowTime += Time.deltaTime;
        if(nowTime>=3) {
            NewBall.SetActive(true);
            transform.eulerAngles = new Vector3(0, Random.Range(30, 120), 0);
            NewBall.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
        }
    }
}

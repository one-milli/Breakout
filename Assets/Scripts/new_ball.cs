using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class new_ball : MonoBehaviour
{
    public static bool LAUNCH = false;
    public static bool SET = false;
    public static float nowTime;
    public GameObject NewBall;
    // Start is called before the first frame update
    void Start()
    {
        nowTime = 0;
        NewBall.SetActive(false);
    }
    void Update()
    {
        nowTime += Time.deltaTime;
        if (nowTime >= 30) LAUNCH = true;
        NewBall.SetActive(LAUNCH);
        if(LAUNCH && !SET)
        {
            transform.eulerAngles = new Vector3(0, Random.Range(30, 120), 0);
            NewBall.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
            SET = true;
        }
    }
}

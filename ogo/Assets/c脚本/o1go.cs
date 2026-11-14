using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class o1go : MonoBehaviour
{
    GameObject flag;
    public float vm;
    public float waittime;
    public float timer = 0;
    private Vector3 stopPos;
    void Start()
    {
        flag = GameObject.Find("zy");
    }
    void Update()
    {
        
        this.transform.LookAt(flag.transform);
        Vector3 p1 = this.transform.position;
        Vector3 p2 = flag.transform.position;
        Vector3 p = p2 - p1;
        float distance = p.magnitude;
        if(distance >= 0.3f)
        {
            float speed = 1f + Mathf.Abs(transform.position.z);
            float move = speed * Time.deltaTime * vm;
            this.transform.Translate(0,0,move);
        }
        else
        {
            timer += Time.deltaTime;
            if(timer >= waittime)
            {
                timer = 0;
                Vector3 pos = flag.transform.position;
                pos.z = -pos.z;
                flag.transform.position = pos;
            }
        }
        
    }
}

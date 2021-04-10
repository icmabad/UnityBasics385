using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonAlly : MonoBehaviour
{
    public GameObject ally;
    float timerStart;
    bool follow=false;

    void Start()
    {
        timerStart = Time.time -5f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(follow){
                follow=false;
            } else {
                Vector3 allyLoc = new Vector3(transform.localPosition.x - 2.2f, transform.localPosition.y - 3.5f, 0f);
                ally.transform.localPosition = allyLoc;
                timerStart = Time.time;
                follow=true;
            }
        }

        if (follow)
        {
            ally.transform.parent = transform;
        }
        else
        {
            ally.transform.parent = null;
        }
    }
}

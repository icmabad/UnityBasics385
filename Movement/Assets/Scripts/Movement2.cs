using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        Vector3 pos = transform.position;

        // "w" can be replaced with any key
        // this section moves the character up
        if (Input.GetKey(KeyCode.Keypad8)||Input.GetKey(KeyCode.W))
        {
            pos.y += speed * Time.deltaTime;
        }

        // "s" can be replaced with any key
        // this section moves the character down
        if (Input.GetKey(KeyCode.Keypad2)||Input.GetKey(KeyCode.S))
        {
            pos.y -= speed * Time.deltaTime;
        }

        // "d" can be replaced with any key
        // this section moves the character right
        if (Input.GetKey(KeyCode.Keypad6)||Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
        }

        // "a" can be replaced with any key
        // this section moves the character left
        if (Input.GetKey(KeyCode.Keypad4)||Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;
    }
}

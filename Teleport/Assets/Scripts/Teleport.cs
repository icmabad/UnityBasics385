using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public int index;
    public SpriteRenderer destination;
    public SpriteRenderer destination2;
    public SpriteRenderer player;
    private bool canTeleport = false;

    void OnTriggerEnter2D(Collider2D other) {
        canTeleport = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && canTeleport)
        {
            int rand = Random.Range(0, 2);
            if(rand==0){
                player.transform.position = destination.transform.position;
            }else{ 
                player.transform.position = destination2.transform.position;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        canTeleport = false;
    }
}

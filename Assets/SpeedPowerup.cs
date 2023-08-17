using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerup : MonoBehaviour
{
    public float increase = 50f;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){
            GameObject player = collision.gameObject;
            Movement playerScript = player.GetComponent<Movement>();

            if (playerScript){
                playerScript.speed += increase;

                Destroy(gameObject);
            }
        }
    }
}

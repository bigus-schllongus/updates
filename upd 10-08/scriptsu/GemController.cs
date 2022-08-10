using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemController : MonoBehaviour 
{
    Rigidbody2D rb;
    GameObject player;
    Vector2 playerDirection;
    float timeStamp;
    bool flyToPlayer;
    public float moveSpeed=4f;

    void Start()
    {
        player=GameObject.Find("player");
        rb = GetComponent<Rigidbody2D> ();
    }

    void Update()
    {
        if(flyToPlayer){
            playerDirection = (player.transform.position - transform.position).normalized;
            rb.velocity = new Vector2(playerDirection.x, playerDirection.y) * moveSpeed;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name.Equals ("GemMagnet")){
            
            flyToPlayer = true;
        }

    }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed = 3f;
    public int damage = 5;
    GameObject enemy;
    public float range=10;
    GameObject boss;

    // Update is called once per frame
    private void Update()
    {
        if(range>=0)
        {
            range-=Time.deltaTime;
        }
        else{
            Destroy(gameObject);
        }
        transform.position += transform.up * Time.deltaTime * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "enemyHitbox"){                        
            collision.gameObject.GetComponentInParent<enemy>().TakeDamage(damage);
            Destroy (gameObject);           
        }        
        if (collision.gameObject.tag == "bossHitbox"){                        
            collision.gameObject.GetComponentInParent<boss>().TakeDamage(damage);
            Destroy (gameObject); 
        }      
    }

}

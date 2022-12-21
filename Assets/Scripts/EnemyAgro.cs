using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAgro : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        
        rb2d= GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        // Distance to Player
        float disToPlayer = Vector2.Distance(transform.position, player.position);
        
        if (disToPlayer < agroRange) 
        {
            // chase the player
            ChasePlayer();
        }
        else
        {
            // stop chase player
            StopChasePlayer();

        }
        
    }

     void StopChasePlayer()
    {
        if(transform.position.x < player.position.x) 
        {
            // enemy is to the left side so move right
            rb2d.velocity = new Vector2(moveSpeed, 0);
            transform.localScale = new Vector2(1, 1);
        }
        else 
        {
            // enemy is to right side so move left
            rb2d.velocity = new Vector2(-moveSpeed, 0);
            transform.localScale = new Vector2(-1, 1);
        }
    }

     void ChasePlayer()
    {
        rb2d.velocity = new Vector2(0, 0);
        
    }
}

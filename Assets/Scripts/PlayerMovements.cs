using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float movespeed = 6;
    private SpriteRenderer sprite;

    private Animator anim;
    private float dirX;
    [SerializeField]private float jumpforce = 14f;
    // Start is called before the first frame update
   private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {

        dirX = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(dirX * movespeed, rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }
        updateanimationupdate();
    }
    private void updateanimationupdate()
    { 
        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("running", false);
            sprite.flipX = false;
        }
    }
}

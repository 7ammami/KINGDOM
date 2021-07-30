using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvementPlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;

    private Animator anim;
    public LayerMask JumpbaleGround;
    float dirX = 0f;
    public float movespeed = 7f;
    public float jumpforce = 14f;

    private enum MovementState { pose, running, jump,fall}
    public AudioSource jumpSoundEffect;
    


    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * movespeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isgrounded())
        {
            jumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }
        UpdateAnimationUpdate();


    }

    private void UpdateAnimationUpdate()
    {
        MovementState state;

        if (dirX > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.pose;
        }


        if (rb.velocity.y > .1f)
        {
            state = MovementState.jump;
        }

        else if (rb.velocity.y<-.1f)
        {
            state = MovementState.fall;
        }

        anim.SetInteger("state", (int)state);
    }
    private bool isgrounded()
    {
      return  Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f,JumpbaleGround);



    }
    

}

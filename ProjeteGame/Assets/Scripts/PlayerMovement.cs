using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    public Vector2 movement;
    public string facing;
    public float speed = 5f;

    private int animDirection;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
     void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
       
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);

        //valor positivo do movimento
        animator.SetFloat("Speed", movement.sqrMagnitude);

        //setando a direção da animação de idle
        CheckDirection();
        animator.SetFloat("LastDirection", animDirection);
    }

    void CheckDirection()
    {
        if (movement.x > 0)
        {
            facing = "right";
            animDirection = 1;
        }
        else if (movement.y > 0)
        {
            facing = "up";
            animDirection = 0;
        }
        else if (movement.x < 0)
        {
            facing = "left";
            animDirection = 3;
        }
        else if (movement.y < 0)
        {
            facing = "down";
            animDirection = 2;
        }

    }

}


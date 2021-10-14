using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    public Vector2 movement;
    public string facing;
    public float speed = 5f;
    private int animDirection;
    private AudioSource audioSource;
    private bool isMoving = false;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //Mapeamentos de respawn do jogador
        if(SceneChanger1.Corredor == true)
        {
            switch (SceneChanger1.LastScene)
            {
                case "Lobby":
                    transform.position = new Vector3(14.14f, -2.29f, 0f);
                    break;
                case "Escritorio":
                    transform.position = new Vector3(8.02f, -2.8f, 0f);
                    break;
                case "SalaDeJantar":
                    transform.position = new Vector3(3.21f, -1.29f, 0f);
                    break;
                case "Banheiro":
                    transform.position = new Vector3(-10.23f, 13.84f, 0f);
                    break;
                case "Biblioteca":
                    transform.position = new Vector3(-2.78f, -2.88f, 0f);
                    break;
                case "Cozinha":
                    transform.position = new Vector3(-3.71f, -2.8f, 0f);
                    break;
                case "Piscina":
                    transform.position = new Vector3(-12.58f, 10.61f, 0f);
                    break;
                case "Sala de estar":
                    transform.position = new Vector3(-11.2f, -2.35f, 0f);
                    break;
                case "Porao":
                    transform.position = new Vector3(-12.67f, -10.87f, 0f);
                    break;
                default:
                    break;
            }
        }
        if (SceneChanger1.Corredor2 == true)
        {
            switch (SceneChanger1.LastScene)
            {
                case "SalaDeEstar":
                    transform.position = new Vector3(-6.3f, -2.26f, 0f);
                    break;
                case "Quarto1":
                    transform.position = new Vector3(0.21f, -2.83f, 0f);
                    break;
                case "Quarto2":
                    transform.position = new Vector3(6.34f, -1.77f, 0f);
                    break;
                case "Quarto cofre":
                    transform.position = new Vector3(3.74f, -0.85f, 0f);
                    break;
            }
        }
        if(SceneChanger1.SalaDeJogos == true)
        {
            switch (SceneChanger1.LastScene)
            {
                case "Lobby":
                    transform.position = new Vector3(-2.24f, 2.86f, 0f);
                    break;
                default:
                    break;
            }
        }
        if (SceneChanger1.SalaDeFora == true)
        {
            switch (SceneChanger1.LastScene)
            {
                case "Piscina":
                    transform.position = new Vector3(5.51f, -12.76f, 0f);
                    break;
                default:
                    break;
            }
        }
        if(SceneChanger1.Banheiro1 == true)
        {
            switch (SceneChanger1.LastScene)
            {
                case "Quarto cofre":
                    transform.position = new Vector3(3.66f, -0.38f, 0f);
                    break;
                default:
                    break;
            }
        }
        if(SceneChanger1.Banheiro2 == true)
        {
            switch (SceneChanger1.LastScene)
            {
                case "Quarto1":
                    transform.position = new Vector3(4.3f, -4.42f, 0f);
                    break;
                default:
                    break;
            }
        }
        if(SceneChanger1.Lobby == true)
        {
            transform.position = new Vector3(-4.4f, -2.18f, 0f);
        }
        if(SceneChanger1.SalaDeEstar == true)
        {
            transform.position = new Vector3(3.45f, 3.09f, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x != 0 || movement.y != 0)  isMoving = true;
        else isMoving = false;

        if (isMoving)
        {
            if (!audioSource.isPlaying) audioSource.Play();
        }
        else audioSource.Stop();
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
			transform.eulerAngles = new Vector3(0f, 180f, 0f);
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
			transform.eulerAngles = new Vector3(0f, 0f, 0f);
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


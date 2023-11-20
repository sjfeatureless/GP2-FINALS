using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.InputSystem;
using TMPro;
using System;

public class PlayerMovement : MonoBehaviour
{
    public GameObject TitleScreen;
    public TextMeshProUGUI healthCounter, coinsCounter, timer;
    //Variable for our speed modifier
    public float moveSpeed;
    //Variable for our player input
    public Vector2 movementInput;
    //Variable for our RigidBody2D
    public Rigidbody2D rigidBody;

    //Variable  for Animator
    public Animator anim;
    public float countdown = 30; //Set initial value
    public float interval = 1; //The interval to decrease the countdown by
    public int coinCounter;
    public int healthPoints;

    //public int coincounter;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
            InvokeRepeating("Tick", 0, interval);
        TitleScreen.SetActive(true);
    }

    public void StartGameButton()
    {
        TitleScreen.SetActive(false);
    }
    void Tick()
    {
        countdown -= interval; //Subtract the interval every tick
    }
    // Update is called once per frame
    void Update()
    {
        healthCounter.text = healthPoints.ToString();
        coinsCounter.text = coinCounter.ToString();
        timer.text = countdown.ToString();

        //While S is pressed run this animation
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    anim.SetTrigger("forwardAnimation");

        //}
        //if (Input.GetKeyUp(KeyCode.S))
        //{
        //    anim.SetTrigger("forwardAnimationPause");

        //}
        ////While W is pressed run this animation
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    anim.SetTrigger("backwardAnimation");

        //}
        //if (Input.GetKeyUp(KeyCode.W))
        //{


        //}
        ////While A is pressed run this animation
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    anim.SetTrigger("leftAnimation");

        //}
        //if (Input.GetKeyUp(KeyCode.A))
        //{


        //}
        ////While D is pressed run this animation
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    anim.SetTrigger("rightAnimation");

        //}
        //if (Input.GetKeyUp(KeyCode.D))
        //{


        //}

        //gets horizontal vertical speed from animator adds movement input.
        anim.SetFloat("Horizontal", movementInput.x);
        anim.SetFloat("Vertical", movementInput.y);
        anim.SetFloat("Speed", movementInput.sqrMagnitude);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coins"))
        {
            coinCounter++;
            Destroy(collision.gameObject);
        }
        
        if (collision.CompareTag("Health slime"))
        {
            healthPoints=200;
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Speed gem"))
        {
            moveSpeed = 10;
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Time"))
        {
            countdown += 30;
            Destroy(collision.gameObject);
        }
    }

    //Update that handles physics
    private void FixedUpdate()
    {
        rigidBody.velocity = movementInput * moveSpeed;
    }

    //Converts our Inputs to Vector
    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();
        {
            if (movementInput.x == 0)
                movementInput.x = 1;
        }
        movementInput.y = 1;
    }

}
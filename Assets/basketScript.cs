using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class basketScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public Boolean running;
    public float speed;
    public logicScript logic;
    public Sprite basket1;
    public Sprite basket2;
    public Sprite basket3;
    public AudioSource collect;
    public AudioSource gameOver;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame   
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true && running)
        {
            Debug.Log("Left pressed");
            myRigidBody.velocity = Vector2.left * speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow) == true && running)
        {
            Debug.Log("Right pressed");
            myRigidBody.velocity = Vector2.right * speed;
        }
        else { 
            myRigidBody.velocity = Vector2.zero;
        }

        updateSprite();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
            Destroy(collision.gameObject);
            collect.Play(); 
        }
        else if (collision.gameObject.layer == 6)
        {
            logic.gameOver();
            running = false;
            gameOver.Play();
        }
    }

    void updateSprite()
    {
        if (logic.playerScore >= 5 && logic.playerScore < 10)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = basket1;
        }
        else if (logic.playerScore >= 10 && logic.playerScore < 15)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = basket2;
        }
        else if (logic.playerScore >= 15)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = basket3;
        }
    }
}

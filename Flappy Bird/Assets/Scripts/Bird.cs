using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private GameManager gameManager;
    [SerializeField] private AudioSource hit, score, wing;
    [SerializeField] private float force;
    private bool isAlive = true;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && isAlive)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector2(0, force);
        wing.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("obstacle") && isAlive)
        {
            hit.Play();
            isAlive = false;
            gameManager.GameOver();
            anim.enabled = false;
        }  
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("score") && isAlive)
        {
            gameManager.Score();
            score.Play();
        }
    }

}

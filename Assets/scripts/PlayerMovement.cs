using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour


{
    
    [SerializeField] private float jumpForce = 10f; 
    [SerializeField] private Transform groundCheck; 
    [SerializeField] private LayerMask groundLayer; 
    [SerializeField] private float checkRadius = 0.2f;  

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    void Update()
    {
       
       

       
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);

       
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce); 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameManager.Instance.ShowGameOverScreen();
            
            Time.timeScale = 0f;
        }
    }
  
}




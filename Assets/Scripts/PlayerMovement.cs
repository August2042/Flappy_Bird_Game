using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
// using TMPro;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public Text coinText;
    int NumCoin;

    public float speed;
    public float jumpSpeed;
    public AudioClip jumpSound; // Assign your jump sound in the Inspector
    private AudioSource audioSource;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

        // Move the player horizontally
        rb.velocity = new Vector2(speed, rb.velocity.y);

        // Check for jump input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        // Apply jump force if grounded (not implemented in this basic example)
        rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);

        // Play jump sound
        if (jumpSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(jumpSound);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check collision with obstacles
        if (collision.gameObject.tag == "Obstacle")
        {
            UImanager.instance.GameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            NumCoin += 1;
            coinText.text = NumCoin.ToString();
            Destroy(collision.gameObject);
        }
    }



}
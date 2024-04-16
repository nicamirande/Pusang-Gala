using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    [SerializeField] private AudioSource deathSoundEffect;

    private Vector3 respawnPoint; // To store the player's last checkpoint

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        // Set the initial respawn point to the player's starting position
        respawnPoint = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trap"))
        {
            Die();
        }
        else if (other.CompareTag("Checkpoint"))
        {
            Debug.Log("Checkpoint reached!");
            respawnPoint = other.transform.position;
        }
    }


    private void Die()
    {
        deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");

        // Call the RestartLevel method after a delay (adjust the delay time as needed)
        Invoke("RestartLevel", 2f);
    }

    private void RestartLevel()
    {
        // Reset the player's position to the last checkpoint
        transform.position = respawnPoint;

        // Resume the game
        rb.bodyType = RigidbodyType2D.Dynamic; // Assuming "Respawn" is the correct trigger name

        anim.SetTrigger("playeridle");
    }
}

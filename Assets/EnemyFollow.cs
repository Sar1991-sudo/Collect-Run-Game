using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;
    public GameObject gameOverText;

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Show game over text and stop the game
            GameManager.instance.gameOverPanel.SetActive(true);
            GameManager.instance.restartButton.SetActive(true);
            Time.timeScale = 0f; // Pause the game
        }
    }
}

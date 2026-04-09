using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float minX = -4f;
    public float maxX = 4f;
    public float minY = -3f;
    public float maxY = 3f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AddScore();
            // Move the coin to a new random position
            transform.position = new Vector2(Random
            .Range(minX, maxX), Random.Range(minY, maxY));
        }
    }
}

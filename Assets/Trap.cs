using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject.Find("Music").GetComponent<AudioSource>().Stop();
            GameManager.instance.audioSource.PlayOneShot(GameManager.instance.gameOverSound);
            GameManager.instance.gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

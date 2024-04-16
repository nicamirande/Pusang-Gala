using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
    private void Start()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player")
        {
            Invoke("CompleteLevel", 1f);
        }
    }
    private void CompleteLevel()
    {
        SceneManager.LoadScene("GameOver");
    }
}
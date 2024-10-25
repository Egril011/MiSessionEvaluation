using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameOver : MonoBehaviour
{
    [SerializeField] Animator gameOver;
    public Transform playerSpawn;
    float timer;
    public bool isGameOver;

    public void Start()
    {
        gameOver = GetComponent<Animator>();
    }

    public void Update()
    {
        timer += Time.deltaTime;
    }

    public void SetGameOver()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            gameOver.SetTrigger("GameOver");
            RespawnPlayer(); 
        }
    }

    void RespawnPlayer()
    {
        var player = FindAnyObjectByType<Player>();
        if (player != null)
        {
            player.transform.position = playerSpawn.position;
            player.gameObject.SetActive(true);
            isGameOver = false;
            gameOver.ResetTrigger("GameOver");
        }
    }
}



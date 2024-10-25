using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameOver : MonoBehaviour
{
    [SerializeField] Animator gameOver;
    public Transform playerSpawn;

    public void Start()
    {
        gameOver = GetComponent<Animator>();
    }

    public void SetGameOver()
    {
        gameOver.SetTrigger("GameOver");
        var player = FindAnyObjectByType<Player>();

        player.transform.position = playerSpawn.position;
        gameOver.SetTrigger("GameOverDone");

    }
}



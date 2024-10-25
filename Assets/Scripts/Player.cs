using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Jobs;

public class Player : MonoBehaviour
{
    [SerializeField] TMP_Text hpText;
    Rigidbody2D rb;
    int playerHp;
    public int speed = 2;
    public float gravity = 2f;
    float TimeHp;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hpText.GetComponent<TMP_Text>();
        playerHp = 100;
        UpdateTextHp();
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        Vector2 velocity = rb.velocity;
        velocity.x = x * speed;

        if (Input.GetKey(KeyCode.Space))
        {
            velocity.y = gravity;
        }
        else
        {
            velocity.y -= gravity * Time.deltaTime;
        }

        rb.velocity = velocity;

        TimeHp += Time.deltaTime;
        
        if (TimeHp > 2)
        {
            LostHP();
            TimeHp = 0;
        }
    }

    public void UpdateTextHp()
    {
        hpText.text = "HP: " + playerHp;
    }

    public void LostHP()
    {
        playerHp = Mathf.Clamp(playerHp-1, 0,100);  
        UpdateTextHp();

        if (playerHp == 0)
        {
            var gameOver = FindAnyObjectByType<GameOver>();
            gameOver.SetGameOver();
        }
    }
    
    public void HpReturn(int hpGagnier)
    {
        playerHp = Mathf.Clamp(playerHp + hpGagnier,0,100);
        UpdateTextHp();
    }
}

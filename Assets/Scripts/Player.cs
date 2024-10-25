using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] TMP_Text hpText;
    Rigidbody2D rb;
    int playerHp;
    public int speed = 2;
    public float gravity = 2f;
    public float swim = 2f;


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
            velocity.y = swim;
        }
        else
        {
            velocity.y -= gravity * Time.deltaTime;
        }

      rb.velocity = velocity;
    }

    public void UpdateTextHp()
    {
        hpText.text = "HP: " + playerHp;
    }
}
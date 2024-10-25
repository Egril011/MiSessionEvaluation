using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melon : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = FindAnyObjectByType<Player>();
        if (player != null)
        {
            player.HpReturn(20);
            Destroy(gameObject);
        }
    }
}

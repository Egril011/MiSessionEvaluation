using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxygene : MonoBehaviour
{
    LineRenderer lineRenderer;
    Player player;

    public void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    public void Update()
    {
        if (player != null)
        {
            //Ai pour les Setposition et que ca suis le joueur
            lineRenderer.SetPosition(0, gameObject.transform.position);
            lineRenderer.SetPosition(1, player.transform.position);
            player.HpGagnier(1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = collision.GetComponent<Player>();

        if (player != null)
        {
            //Ai pour les Setposition
            player.HpGagnier(10 * Time.deltaTime);
            lineRenderer.SetPosition(0, gameObject.transform.position);
            lineRenderer.SetPosition(1, player.transform.position);
           
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Ai
        if (collision.GetComponent<Player>() == player)
        {
            player = null; 
            lineRenderer.SetPosition(1, transform.position); 
        }
    }

}

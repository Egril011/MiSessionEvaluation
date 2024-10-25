using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    Camera cam;
    public Transform player;

    public void Start()
    {
       cam = Camera.main;
    }

    public void Update() 
    {
        Vector3 posCam = cam.transform.position;
        posCam.x = player.transform.position.x;
        cam.transform.position = posCam;
    }
    
}

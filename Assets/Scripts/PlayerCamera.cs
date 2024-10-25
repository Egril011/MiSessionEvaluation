using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    Camera cam;

    public void Start()
    {
       cam = Camera.main;
    }

    public void Update() 
    {
        Vector3 posCam = cam.transform.position;
        posCam.x = transform.position.x;
        cam.transform.position = posCam;
    }
    
}

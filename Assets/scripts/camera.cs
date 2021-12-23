using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public player player;
    public Vector3 Cameraposition;
    void Update()
    {
       
        Vector3 position = player.transform.position + Cameraposition;
        Vector3 camera = new Vector3(Cameraposition.x, Cameraposition.y, position.z);
        transform.position = camera;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    public Rigidbody player;
    private Vector3 _prevewmouse;
    public float Senitivity;
    public float speed;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float delta = Input.mousePosition.x - _prevewmouse.x;
            float Speed = speed * Time.deltaTime;
            Vector3 Delta = new Vector3(-delta,  0.5f, -Speed);

            player.velocity = Delta;
        }


        _prevewmouse = Input.mousePosition;
    }
}

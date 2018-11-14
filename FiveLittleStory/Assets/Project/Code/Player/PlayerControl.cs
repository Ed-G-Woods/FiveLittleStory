using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControl : MonoBehaviour {

    public float speed = 50;

    private Rigidbody2D _rigidbody;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Start () {
		
	}
	void Update () {
		
	}
    private void FixedUpdate()
    {
        Vector2 movement = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement.y += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement.y -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement.x += 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x -= 1;
        }

        _rigidbody.velocity = movement * speed;


    }


}

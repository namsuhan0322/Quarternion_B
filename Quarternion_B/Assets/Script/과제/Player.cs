using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 xInput = new Vector2();
    Rigidbody2D _rigidbody2D;
    
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        Move();
    }

    void Move()
    {
        xInput.x = Input.GetAxisRaw("Horizontal");

        xInput.Normalize();

        _rigidbody2D.velocity = xInput * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Poop poop = other.gameObject.GetComponent<Poop>();
        if (poop != null)
        {
            if (poop.poopObj.poopType == PoopObj.PoopType.Poop)
            {
                Debug.Log("죽음!");
                Die();
            }
            else if (poop.poopObj.poopType == PoopObj.PoopType.GoldPoop)
            {
                Debug.Log("황금!");
            }
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}

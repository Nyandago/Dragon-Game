﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public Vector2 StartingVelocity;

  
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = StartingVelocity;
        Destroy(gameObject, 10); //destroying fireballs after 10 seconds
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       var enemy = collision.collider.GetComponent<Enemy>();
        enemy?.Die();

        Destroy(gameObject);
    }
}

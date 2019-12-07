﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallCollisionComponent2 : MonoBehaviour
{
    public Vector2 vec;

    void Update()
    {
        transform.Translate(vec*Time.deltaTime*15);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Untagged")
        {
            Destroy(gameObject);
        }
    }
}
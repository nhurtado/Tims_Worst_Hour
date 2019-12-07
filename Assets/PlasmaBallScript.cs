﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaBallScript : MonoBehaviour
{
    public Vector2 vec;

    void Update()
    {
        transform.Translate(vec*Time.deltaTime*10);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
        print(collision);

        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Untagged")
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger");
        print(collision);
    }
}
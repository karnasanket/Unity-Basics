﻿using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb2d;
    private Vector3 lastVelocity;

    SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = speed * Random.insideUnitCircle.normalized;
    }

    void Update()
    {
        lastVelocity = rb2d.velocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        sprite.color = new Color(
      Random.Range(0f, 1f), 
      Random.Range(0f, 1f), 
      Random.Range(0f, 1f)
  );
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
        rb2d.velocity = direction * Mathf.Max(speed, 0f);
    }
}

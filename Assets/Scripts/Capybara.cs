using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capybara : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Vector3 _force = Vector3.up;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void Update ()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _spriteRenderer.flipX = true;
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _spriteRenderer.flipX = false;
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Rigidbody2D fruit = collision.rigidbody;
        if(fruit != null)
        {
            fruit.AddForce(_force, ForceMode2D.Impulse);
        }
    }
}

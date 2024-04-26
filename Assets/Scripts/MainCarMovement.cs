using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCarMovement : MonoBehaviour
{
    [SerializeField] private float _verticalSpeed;
    [SerializeField] private float _horizontalSpeed;
    [SerializeField] private float _defaultSpeed;
    private float _verticalMove;
    private Rigidbody2D _rb;
    private float _horizontalMove;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _verticalMove = Input.GetAxis("Vertical"); // Dikey hareket paketi eklendi. Yani w ya da yukarı ok tuşuna basılırsa hızı 0'dan 1'e arttırır. Tam tersinde ise -1'e çeker.
        _horizontalMove = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(_horizontalMove * _horizontalSpeed * Time.deltaTime, _defaultSpeed + _verticalMove * _verticalSpeed * Time.deltaTime);
        //Sınır Kontrolleri
        if (transform.position.x > 1.75f)
        {
            Vector3 right_limit = new Vector3(1.85f, transform.position.y);
            transform.position = right_limit;
        }
        if (transform.position.x < -1.70f)
        {
            Vector3 left_limit = new Vector3(-1.77f, transform.position.y);
            transform.position = left_limit;
        }
    }
}

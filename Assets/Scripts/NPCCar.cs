using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCar : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _defaultSpeed;
    private int _goLane;
    [SerializeField] private List<Sprite> _cars;
    private SpriteRenderer _spriteRenderer;
    public int _carSprite;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _goLane = Random.Range(0, 4); // 0, 1, 2, veya 3 arasında rastgele bir sayı alır
        _defaultSpeed = Random.Range(6f, 10f);

        // Araç pozisyonunu belirle
        switch (_goLane)
        {
            case 0:
                transform.position = new Vector3(-1.45f, transform.position.y + 10, 0);
                break;
            case 1:
                transform.position = new Vector3(-0.53f, transform.position.y + 10, 0);
                break;
            case 2:
                transform.position = new Vector3(0.5f, transform.position.y + 10, 0);
                break;
            case 3:
                transform.position = new Vector3(1.48f, transform.position.y + 10, 0);
                break;
        }

        // Rastgele bir araba görüntüsü seç
        _carSprite = Random.Range(0, _cars.Count);
        _spriteRenderer.sprite = _cars[_carSprite];
    }

    void FixedUpdate()
    {
        // Hızı ayarla
        _rb.velocity = new Vector2(_rb.velocity.x, _defaultSpeed *10* Time.deltaTime);
    }
}
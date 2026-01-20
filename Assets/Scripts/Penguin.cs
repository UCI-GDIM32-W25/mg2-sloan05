using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Penguin : MonoBehaviour
{
    [SerializeField] private GameObject _Penguin;

    [SerializeField] private Rigidbody2D _rigidbody;

    [SerializeField] private float _jumpVelocity = 5f;

    [SerializeField] private GameController _gameController;

    private bool _isGrounded = true;



    

    // Start is called before the first frame update
    void Start()
    {
        if (_rigidbody == null) 
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rigidbody.velocity = new Vector2 (_rigidbody.velocity.x, _jumpVelocity);
            _isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }
    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.CompareTag("Coin"))
        {
            Debug.Log("PICKED COIN");
            _gameController.AddPoint();
         Destroy (other.gameObject);
        }
        
    }
}

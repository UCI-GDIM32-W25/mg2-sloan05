using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _Penguin;

    [SerializeField] private 
    // Start is called before the first frame update
    void Start()
    {
        if (_playerTransform == null) _playerTransform = transform;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = new Vector2 (_rigidbody.velocity.x, 4.0f);
        }
    }
    private void OnTriggerEnter2D (Collider collider)
    {
        Destroy (collideer.GameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] private float _speed = 2;
    [SerializeField] private float _jumpForce = 200;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] float _jumpCount = 0;

    // Update is called once per frame
    void Update()
    {
        var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * _speed;
        vel.y = _rb.velocity.y;
        _rb.velocity = vel;
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (_jumpCount < 10) {
                _jumpCount += 1;
                _rb.AddForce(Vector3.up * _jumpForce);
        } };
    }
}

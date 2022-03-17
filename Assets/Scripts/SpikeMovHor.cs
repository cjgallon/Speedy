using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovHor : MonoBehaviour
{
    public Vector2 LaunchVelocity;
    private Rigidbody2D _rigidBody;
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.velocity = LaunchVelocity;
    }
    void Update()
    {
        _rigidBody.velocity = new Vector2(LaunchVelocity.x, _rigidBody.velocity.y);
    }

}
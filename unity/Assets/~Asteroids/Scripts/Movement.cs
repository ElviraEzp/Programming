using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{

    public class Movement : MonoBehaviour
    {
        public float speed = 20f; // Units to travel per second
        public float rotationSpeed = 360f; // Amount of rotation per second

        private UnityEngine.Rigidbody2D rigid; //Reference to attached RigidBody2D

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<UnityEngine.Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            // Check if A key is pressed
            if (Input.GetKey(KeyCode.A))
            {
                // Rotate left
                transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            }

            // Check if D key is pressed
            if (Input.GetKey(KeyCode.D))
            {
                // Rotate right
                transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
            }

            // Check if W key is pressed
            if (Input.GetKey(KeyCode.W))
            {
                // Move in facing direction
                rigid.AddForce(transform.up * speed);
            }
        }
    }

    internal class Rigidbody2D
    {
        internal void AddForce(Vector3 vector3, ForceMode2D impulse)
        {
            throw new NotImplementedException();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{

    public class Movement : MonoBehaviour
    {
        public float speed = 20f;
        public float rotationSpeed = 360f;

        private RigidBody2D rigid; 

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.forward, rotationSpeed);
            }
        }
    }
}
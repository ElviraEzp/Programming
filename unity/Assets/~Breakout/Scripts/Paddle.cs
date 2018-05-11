using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{
    public class Paddle : MonoBehaviour
    {
        public float movemnentSpeed = 10;
        public Ball currentBall; //Reference to ball for firing
        public Vector3[] directions =
        {
            new Vector2(-1f, 1f),
            new Vector2( 1f, 1f)
        };

        // Use this for initialization
        void Start()
        {
            currentBall = GetComponentInChildren<Ball>();
        }

        void Fire()
        {
            // Detach child (ball)
            currentBall.transform.SetParent(null);
            // Selet random dir from array of directions
            Vector3 randomDir = directions[Random.Range(0, directions.Length)];
            // Fire off ball in randomDirection
            currentBall.Fire(randomDir);
        }

        void CheckInput()
        {
            // Check if space is pressed
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Perform logic for firing
                Fire();
            }  
        }

        void Movement()
        {
            // Get horizontal axis
            float inputH = Input.GetAxis("Horizontal");
            // Create a force using horizontal input
            Vector3 force = transform.right * inputH; // Left/Right movement
            force *= movemnentSpeed; // Add movement speed
            force *= Time.deltaTime; //Apply deltaTime
            transform.position += force; //Apply to transform
        }

        // Update is called once per frame
        void Update()
        {
            CheckInput();
            Movement();
        }
    }
}

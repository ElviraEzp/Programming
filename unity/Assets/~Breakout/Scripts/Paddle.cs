using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{
    public class Paddle : MonoBehaviour
    {
        public float movemnentSpeed = 20f;
        public Ball currentBall; //Reference to ball for firing
        // Directions array defaults to two values
        public Vector2[] directions = new Vector2[]
    {
            new Vector2(-0.5f, 0.5f),
            new Vector2(0.5f, 0.5f)
    };

        // Use this for initialization
        void Start()
        {
            // Grabs currentBall from children of the Paddle
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
            Vector3 force = transform.right * inputH;
            // Add movement speed
            force *= movemnentSpeed;
            //Apply deltaTime to force
            force *= Time.deltaTime;
            //Apply to transform
            transform.position += force;
        }

        // Update is called once per frame
        void Update()
        {
            CheckInput();
            Movement();
        }
    }
}

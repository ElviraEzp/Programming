﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SunnyLand
{
    public class PlayerController : MonoBehaviour
    {
        public float speed = 5f;
        public int health = 100;
        public int damage = 50;
        public float maxVelocity = 5f;
        public float maxSlopeAngle = 45f;
        [Header("Grounding")]
        public float rayDistance = .25f;
        public bool isGrounded = false;
        public bool isOnSlope = false;
        [Header("Crouch")]
        public bool isCrouching = false;
        [Header("Jump")]
        public float jumpHeight = 2f;
        public int maxJumpCount = 2;
        public bool isJumping = false;
        [Header("Climb")]
        public float climbSpeed = 5f;
        public bool isClimbing = false;

        private Vector3 groundNormal = Vector3.up;
        private int currentJump = 0;
        private float inputH, inputV;

        private SpriteRenderer rend;
        private Rigidbody2D rigid;

        #region Unity Functions
        // Use this for initialization
        void Awake()
        {
            rend = GetComponent<SpriteRenderer>();
            rigid = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            PerformMove();
        }
        void FixedUpdate()
        {

        }
        void OnDrawGizmos()
        {
            Ray groundRay = new Ray(transform.position, Vector3.down);
            Gizmos.DrawLine(groundRay.origin, groundRay.origin + groundRay.direction * rayDistance);

            Vector3 right = Vector3.Cross(groundNormal, Vector3.forward);
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position - right, transform.position + right);
        }
        #endregion

        #region Custom Functions
        //Inputs
        public void Jump()
        {

        }
        public void Crouch()
        {

        }
        public void UnCrouch()
        {

        }
        public void Move(float horizontal)
        {
            if(horizontal != 0)
            {
                //Flip the sprite based on input direction
                rend.flipX = horizontal < 0;
            }
            inputH = horizontal;
        }
        public void Climb(float vertical)
        {

        }
        public void Hurt(int damage)
        {

        }
        //Actions
        void PerformClimb()
        {

        }
        void PerformMove()
        {
            //Calculate 'right' depending on ground surface normal
            Vector3 right = Vector3.Cross(groundNormal, Vector3.forward);
            rigid.AddForce(right * inputH * speed);
            LimitVelocity();
        }
        void PerformJump()
        {

        }
        //Detectors
        void DetectClimbable()
        {

        }
        void DetectGround()
        {

        }
        void CheckGround(RaycastHit2D hit)
        {

        }
        void CheckEnemy(RaycastHit2D hit)
        {

        }
        //Helpers
        void LimitVelocity()
        {
            Vector3 vel = rigid.velocity;
            if (vel.magnitude > maxVelocity)
            {
                vel = vel.normalized * maxVelocity;
            }
            rigid.velocity = vel;
        }
        void StopClimbing()
        {

        }
        void EnablePhysics()
        {

        }
        void DisablePhysics()
        {

        }
        #endregion
    }
}

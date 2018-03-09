using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GoneHome
{
    public class Player : MonoBehaviour
    {
        public float acceleration = 10f;
        public float maxVelocity = 20f;
        public GameObject deathParticles; 

        private Rigidbody rigid;

        private Vector3 spawnPoint;

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();

            spawnPoint = transform.position; 
        }

        // Update is called once per frame
        void Update()
        {
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");

            Vector3 inputDir = new Vector3(inputH, 0, inputV);

            Transform cam = Camera.main.transform;
            inputDir = Quaternion.AngleAxis(cam.eulerAngles.y, Vector3.up) * inputDir;

            rigid.AddForce(inputDir * acceleration);

            if(rigid.velocity.magnitude > maxVelocity)
            {
                rigid.velocity = rigid.velocity.normalized * maxVelocity;
            }

        }

        public void Reset()
        {
            GameObject clone = Instantiate(deathParticles);
            clone.transform.position = transform.position;
            transform.position = spawnPoint;
            rigid.velocity = Vector3.zero;
        }
    }
}
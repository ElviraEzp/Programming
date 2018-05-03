using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Asteroids
{
    public class Moving : MonoBehaviour
    {
        public float rotationSpeed = 360f;
        public float movementSpeed = 10f;


        void Rotation()
        {
            //Check if left is pressed
            if (Input.GetKey(KeyCode.LeftArrow))

            {
                // Rotate Left
                transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);

            }
            if (Input.GetKey(KeyCode.RightArrow))

            {
                // Rotate Right
                transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);


            }
        }



        void Movement()
        {
            if (Input.GetKey(KeyCode.UpArrow))


            {
                //Vector3 position = transform.position;
                //position.y += movementSpeed * Time.deltaTime;                                    
                //transform.position = position;
                transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
            }
            {
                print("I have pressed the up key!");
            }
            if (Input.GetKey(KeyCode.DownArrow))

            {
                transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);

            }
        }
        // Update is called once per frame
        void Update()
        {
            //Call 'Movement()' function
            Movement();
            // Call 'Rotation()' function
            Rotation();


        }
    }
}
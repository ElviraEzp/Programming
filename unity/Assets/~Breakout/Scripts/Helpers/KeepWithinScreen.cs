﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{ 
[RequireComponent(typeof(Renderer))]  
 public class KeepWithinScreen : MonoBehaviour
    {
        private Renderer rend; // Renderer attached to the object
        private Camera cam; // Camera container (variable)
        private Bounds camBounds; // Camera Bounds structure
        private float camWidth, camHeight;

        // Use this for initialization
        void Start()
        {
            cam = Camera.main;
            rend = GetComponent<Renderer>();
        }

        // Update is called once per frame
        void UpdateCamBounds()
        {
            // Calculate camera bounds
            camHeight = 2f * cam.orthographicSize;
            camWidth = camHeight * cam.aspect;
            camBounds = new Bounds(cam.transform.position, new Vector3(camWidth, camHeight));
        }

        Vector3 CheckBounds()
        {
            Vector3 pos = transform.position;
            Vector3 size = rend.bounds.size;
            float halfWidth = size.x * 0.5f;
            float halfHeight = size.y * 0.5f;
            float halfCamWidth = camWidth * 0.5f;
            float halfCamHeight = camHeight * 0.5f;
            // Check left
            if (pos.x - halfWidth < camBounds.min.x)
            {
                pos.x = camBounds.min.x + halfWidth;
            }
            // Check right
            if (pos.x + halfWidth > camBounds.max.x)
            {
                pos.x = camBounds.max.x - halfWidth;
            }
            //Check down
            if (pos.y - halfHeight < camBounds.min.y)
            {
                pos.y = camBounds.min.y + halfHeight;
            }
            //Check up
            if (pos.y + halfHeight < camBounds.max.y)
            {
                pos.y = camBounds.max.y - halfHeight;
            }
            return pos; // Return adjusted position
        }

        // Update is called once per frame
        void Update ()
        {
            // Update the camera bounds
            UpdateCamBounds();
            // Set the position after checking the bounds
            transform.position = CheckBounds();
        }
    }
}

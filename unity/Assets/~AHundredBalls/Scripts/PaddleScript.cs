using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow)) // Check if down arrow is pressed
        {
            // Modify parameter
            anim.SetBool("isOpened", true);
        }
        else
        {
            // Set that parameter to false
            anim.SetBool("isOpened", false);
        }
    }
}

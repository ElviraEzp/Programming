using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assessment1
{
    public class Collector : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Coin"))
            {
                other.gameObject.SetActive(false);
            }
        }
    }
}

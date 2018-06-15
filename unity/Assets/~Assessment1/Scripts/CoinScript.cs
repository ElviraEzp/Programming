using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assessment1
{

    public class CoinScript : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            transform.Rotate(90 * Time.deltaTime, 0, 0);
        }
    }
}

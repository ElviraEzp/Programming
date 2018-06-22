using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

namespace Assessment1
{


    public class DestroyCoins : MonoBehaviour
    {
        public Text countText; // reference to score in UI
        public Text winText;
        private Rigidbody2D rigid; // reference to attached Rigidbody2D
        private int count; // score count

        // Use this for initialization
        void Start()
        {
            // grab reference to rigidbody2D component
            // NOTE: it gets this from the GameObject this script is attached to
            rigid = GetComponent<Rigidbody2D>();

            // set score to 0
            count = 0;

            // refers to count + count.tostring
            SetCountText();

            // refers to setting the end of game message
            winText.text = "";
        }

        // Update is called once per frame
        void Update()
        {

        }
        void OnTriggerEnter2D(Collider2D col)
        // Triggering "coins" to collect/destroy when player collides with them
        {
            if (col.gameObject.CompareTag("Coin"))
            {
                Destroy(col.gameObject);
                // deactivates the game object "coin"
                count = count + 1;
                // adds value of 1 to the score as each coin is collected
                SetCountText();


            }
        }

        void SetCountText()
        {
            countText.text = "Count: " + count.ToString();
            if (count >= 5)
            {
                winText.text = "You Win"; // sets end game message
            }
        }
    }
}

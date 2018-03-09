using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace GoneHome
{
    public class GameManager : MonoBehaviour
    {
        public void NextLevel()
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }
        public void ResetLevel()
        {
            //Grab all enemies and reset them
            FollowEnemy[] enemies = FindObjectsOfType<FollowEnemy>();
            //Loop through all enemies and reset them
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Reset();
            }
            //Grab the Player and reset it
            Player player = FindObjectOfType<Player>();
            player.Reset();
        }
    }
}
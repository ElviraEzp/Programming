using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class AsteroidSpawner : MonoBehaviour
    {
        public GameObject[] asteroidPrefabs; // Array of prefabs to pawn
        public float spawnRate = 1f;
        public float spawnRadius = 5f;

        void Spawn()
        {
            // Randomise a position
            Vector3 rand = Random.insideUnitSphere * spawnRadius;
            // Cancel the z axis on position
            rand.z = 0f;
            Vector3 position = transform.position + rand;
            int randIndex = Random.Range(0, asteroidPrefabs.Length);
            GameObject randAsteroid = asteroidPrefabs[randIndex];
            GameObject clone = Instantiate(randAsteroid);
            clone.transform.position = position;
        }

        // Use this for initialization
        void Start()
        {
            // Calls a function a specified amount of times
            InvokeRepeating("Spawn", 0, spawnRate);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

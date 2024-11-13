using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnXRight = 21.75f;
    public float spawnXLeft = -21.75f;
    private float spawnZ = 20f;

    public float startDelay = 3.0f;
    public float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval); 

        Debug.Log(animalPrefabs[0]);
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.X))
        {
            SpawnRandomAnimals();



        }

      
    }
    void SpawnRandomAnimals()

    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPosition = new Vector3(Random.Range(spawnXLeft, spawnXRight), 0, spawnZ);

        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnXRight = 21.75f;
    public float spawnXLeft = -21.75f;
    private float spawnZ = 20f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(animalPrefabs[0]);
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.X))
        {
            

            int animalIndex = Random.Range(0, animalPrefabs.Length);

            Vector3 spawnPosition = new Vector3(Random.Range(spawnXLeft, spawnXRight), 0, spawnZ);

            Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}

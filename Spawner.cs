using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spherePrefab;

    //public float sample;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnSphere", 0.1f, 0.2f);
    }

    void SpawnSphere()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-4, 4), 1f, Random.Range(-4, 4));

        Instantiate(spherePrefab, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

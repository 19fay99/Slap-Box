using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalCrateSpawner : MonoBehaviour
{
    public GameObject[] Prefabs;
    private float startDelay = 20;
    public float spawnInterval = 15;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCrate", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCrate()
    {
        int PrefabIndex = Random.Range(0, Prefabs.Length);
        Vector2 spawnPos = new Vector2(0, 0);

        Instantiate(Prefabs[PrefabIndex], spawnPos, Prefabs[PrefabIndex].transform.rotation);
    }


}

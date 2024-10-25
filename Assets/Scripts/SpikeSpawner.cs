using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    [SerializeField] GameObject spikePrefabs;
    public Transform spkieSpawn;
    float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            SpawnSpike();
            timer = 0;
        }
    }

    void SpawnSpike()
    {
        Instantiate(spikePrefabs,spkieSpawn);
    }
}

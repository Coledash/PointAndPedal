using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrogodiiliSpawnerScript : MonoBehaviour
{
    public GameObject SpawnPrefab;
    public int spawnChance;
    public float whenToStartSpawning;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (UnityEngine.Random.Range(0, 10000) < spawnChance && AudioManagerScript.instance.timeSinceStart > whenToStartSpawning)
        {
            Instantiate(SpawnPrefab, transform);
            if (AudioManagerScript.instance.playerDead) Destroy(gameObject);
        }

    }
}

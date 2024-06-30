using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESSpawnerScript : MonoBehaviour
{
    public GameObject SpawnPrefab;
    public int spawnChance;

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
        if (UnityEngine.Random.Range(0, 10000) < spawnChance)
        {
            Instantiate(SpawnPrefab, transform);            
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enermyObjs;
    
    
    public float maxSpawnDelay;
    public float curSpawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curSpawnDelay += Time.deltaTime;

        if(curSpawnDelay > maxSpawnDelay)
        {
            SpawnEnermy();
            curSpawnDelay = 0;

        }
    }
    void SpawnEnermy()
    {
        int ranEnermy = Random.Range(0, 3);
        int ranPoints = Random.Range(0, 3);
        Instantiate(enermyObjs[ranEnermy],
            spawnPoints[ranPoints].position,
            spawnPoints[ranPoints].rotation);

    }
}

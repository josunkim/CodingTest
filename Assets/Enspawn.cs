using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enspawn : MonoBehaviour
{
    public float spwanTime = 3f;
    public float curTime;
    public Transform[] spawnPoints;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (curTime >= spwanTime)
        {
            int x = Random.Range(0, spawnPoints.Length);
            SpawnEnemy(x);
        }
        curTime += Time.deltaTime;
    }
    public void SpawnEnemy(int ranNum)
    {
        curTime = 0;
        Instantiate(enemy, spawnPoints[ranNum]);

    }
}

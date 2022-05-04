using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour
{
    public Transform[] points;
    
    public GameObject monsterPrefab;

    public float createTime;
   
    public int maxMonster = 10;
 
    public bool isGameOver = false;

    void Start()
    {
        
        points = GameObject.Find("SpawnPosition").GetComponentsInChildren<Transform>();

        if (points.Length > 0)
        {
            StartCoroutine(this.CreateMonster());
        }
    }

    IEnumerator CreateMonster()
    {
       
        while (!isGameOver)
        {
            //현재 생성된 몬스터 개수 산출
            int monsterCount = (int)GameObject.FindGameObjectsWithTag("Enermy").Length;

            if (monsterCount < maxMonster)
            {
                
                yield return new WaitForSeconds(createTime);

                
                int idx = Random.Range(1, points.Length);
                
                Instantiate(monsterPrefab, points[idx].position, points[idx].rotation);
            }
            else
            {
                yield return null;
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject[] target;
    public Transform spawnPoint;
    private bool isDestroyed;
    int spawnIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            isDestroyed = true;
        }
        else
        {
            isDestroyed = false;
        }

        if(isDestroyed == true)
        {
            Invoke("Spawn", 0.4f);
        }
    }
    void Spawn()
    {
        /*int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        if (enemyCount >= enemyLimit) return;
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

        enemyCount++;*/
        //Instantiate(target, spawnPoint.position, Quaternion.identity);
        spawnIndex++;
    }


}

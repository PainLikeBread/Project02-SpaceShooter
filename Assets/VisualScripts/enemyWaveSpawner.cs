using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWaveSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy3Prefab;
    
    [SerializeField]
    private float enemy3Interval = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(enemy3Interval, enemy3Prefab));
    }

    private IEnumerator spawnEnemy(float enemyInterval, GameObject enemy)
    {
        yield return new WaitForSeconds(enemyInterval);
        Vector3 spawnerPosition = transform.position;
        GameObject newEnemy = Instantiate(enemy, spawnerPosition, Quaternion.identity);
        StartCoroutine(spawnEnemy(enemyInterval, enemy));
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    private GameObject enemy2Prefab;
    
    [SerializeField]
    private float enemyInterval = 10f;

    [SerializeField]
    private float enemy2Interval = 45f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab));

        StartCoroutine(spawnEnemy(enemy2Interval, enemy2Prefab));
    }

    private IEnumerator spawnEnemy(float enemyInterval, GameObject enemy)
    {
        yield return new WaitForSeconds(enemyInterval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(-9.7f, Random.Range(-3f, 3f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(enemyInterval, enemy));
    }
}

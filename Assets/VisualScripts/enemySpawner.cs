using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    
    [SerializeField]
    private float enemyInterval = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab));
    }

    private IEnumerator spawnEnemy(float enemyInterval, GameObject enemy)
    {
        yield return new WaitForSeconds(enemyInterval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(-9.7f, Random.Range(-3f, 3f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(enemyInterval, enemy));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject asteroidPrefab;
    
    [SerializeField]
    private float interval = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnAsteroid(interval, asteroidPrefab));
    }

    private IEnumerator spawnAsteroid(float interval, GameObject asteroid)
    {
        yield return new WaitForSeconds(interval);
        GameObject newAsteroid = Instantiate(asteroid, new Vector3(Random.Range(-9.3f, 9.3f), -6, 0), Quaternion.identity);
        StartCoroutine(spawnAsteroid(interval, asteroid));
    }
}

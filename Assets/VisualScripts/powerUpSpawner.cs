using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject powerUpPrefab;
    
    [SerializeField]
    private float powerInterval = 30f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnPower(powerInterval, powerUpPrefab));
    }

    private IEnumerator spawnPower(float powerInterval, GameObject powerUp)
    {
        yield return new WaitForSeconds(powerInterval);
        GameObject newPower = Instantiate(powerUp, new Vector3(Random.Range(-8,8), Random.Range(-3.5f, 3.5f), 0), Quaternion.identity);
        StartCoroutine(spawnPower(powerInterval, powerUp));
    }
}

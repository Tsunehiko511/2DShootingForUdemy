using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;

    private int random;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        Vector3 spawnPositon = new Vector3(
            Random.Range(-2.9f,2.9f),
            transform.position.y,
            transform.position.z);

        Instantiate(EnemyPrefab, spawnPositon, transform.rotation);
    }
}

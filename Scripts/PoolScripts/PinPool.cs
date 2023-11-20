using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinPool : MonoBehaviour
{
    [SerializeField] private GameObject pinPrefab;
    [SerializeField] private int poolSize = 4;
    [SerializeField] private float spawnTime = 2f;
    [SerializeField] private float zSpawnPosition = 70;
    [SerializeField] private float minXPosition = -4.8f;
    [SerializeField] private float maxXPosition = 4.3f;

    private float timeElapsed;
    private int obstacleCount;
    private GameObject[] pin;
    void Start()
    {
        pin = new GameObject[poolSize];
        for (int i = 0; i < poolSize; i++)
        {
            pin[i] = Instantiate(pinPrefab);
            pin[i].SetActive(false);
        }
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > spawnTime)
        {
            SpawnPin();
        }
    }
    private void SpawnPin()
    {
        timeElapsed = 0f;

        float xSpawnPosition = Random.Range(minXPosition, maxXPosition);
        Vector3 spawnPosition = new Vector3 (xSpawnPosition, -0.45f, zSpawnPosition);
        pin[obstacleCount].transform.position = spawnPosition;

        if (!pin[obstacleCount].activeSelf)
        {
            pin[obstacleCount].SetActive(true);
        }

        obstacleCount++;

        if (obstacleCount == poolSize)
        {
            obstacleCount = 0;
        }

    }
}

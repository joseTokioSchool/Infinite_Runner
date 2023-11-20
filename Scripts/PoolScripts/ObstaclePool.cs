using UnityEngine;

public class ObstaclePool : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private int poolSize = 4;
    [SerializeField] private float spawnTime;
    [SerializeField] private float zSpawnPosition = 70;
    [SerializeField] private float minXPosition = -4.8f;
    [SerializeField] private float maxXPosition = 4.3f;

    private float timeElapsed;
    private int obstacleCount;
    private GameObject[] obstacle;
    void Start()
    {
        obstacle = new GameObject[poolSize];
        for (int i = 0; i < poolSize; i++)
        {
            obstacle[i] = Instantiate(obstaclePrefab);
            obstacle[i].SetActive(false);
        }
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > spawnTime)
        {
            SpawnObstacle();
        }
    }
    private void SpawnObstacle()
    {
        spawnTime = Random.Range(2, 4);
        timeElapsed = 0f;

        float xSpawnPosition = Random.Range(minXPosition, maxXPosition);
        Vector3 spawnPosition = new Vector3(xSpawnPosition, 0.06f, zSpawnPosition);
        obstacle[obstacleCount].transform.position = spawnPosition;

        if (!obstacle[obstacleCount].activeSelf)
        {
            obstacle[obstacleCount].SetActive(true);
        }

        obstacleCount++;

        if (obstacleCount == poolSize)
        {
            obstacleCount = 0;
        }

    }
}

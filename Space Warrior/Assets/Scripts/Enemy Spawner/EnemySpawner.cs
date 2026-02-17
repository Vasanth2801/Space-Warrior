using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRange = 2.7f;
    [SerializeField] GameObject enemy;
    private float timer;

    void Start()
    {
        SpawnEnemy();
    }

    void Update()
    {
        if(timer > maxTime)
        {
            SpawnEnemy();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void SpawnEnemy()
    {
        Vector3 spawnPos = transform.position + new Vector3(-0, Random.Range(-heightRange, heightRange));
        GameObject spaceship = Instantiate(enemy,spawnPos,Quaternion.identity);
    }
}

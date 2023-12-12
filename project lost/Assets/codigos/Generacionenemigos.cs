using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int initialWave = 1;
    public int enemiesPerWave = 4;
    public float waveDelay = 2f;

    private int currentWave;
    private int enemiesRemaining;
    private bool isSpawning;

    void Start()
    {
        currentWave = initialWave;
        enemiesRemaining = currentWave;
        isSpawning = true;

        StartWave();
    }

    void StartWave()
    {
        for (int i = 0; i < enemiesRemaining; i++)
        {
            // Generar un enemigo en una posición aleatoria
            Vector3 spawnPosition = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }

        isSpawning = false;
    }

    void Update()
    {
        // Verificar si se han eliminado todos los enemigos de la oleada actual
        if (enemiesRemaining <= 0 && !isSpawning)
        {
            // Esperar un tiempo antes de comenzar la siguiente oleada
            Invoke("StartNextWave", waveDelay);
            isSpawning = true;
        }
    }

    void StartNextWave()
    {
        currentWave++;
        enemiesRemaining = currentWave * enemiesPerWave;
        StartWave();
    }
}

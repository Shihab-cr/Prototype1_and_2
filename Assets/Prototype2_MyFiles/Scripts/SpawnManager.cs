using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefab;
    private float spawnRange = 14f;
    private float spawnRangeSides = 8f;

    private float TopSpawnerPosition = 20f;
    private float LeftSpawnerPosition = -20f;
    private float RightSpawnerPosition = 20f;
    private float BottomSpawnerPosition = -10f;


    private float startDelay = 2;
    private float spawnInterval = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalFromTop", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalFromLeft", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalFromRight", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimalFromTop();
        }
    }

    private void SpawnRandomAnimalFromTop()
    {

        int animalIndex = Random.Range(0, animalsPrefab.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange, spawnRange), 0, TopSpawnerPosition);
        Instantiate(animalsPrefab[animalIndex], spawnPosition, animalsPrefab[animalIndex].transform.rotation);
    }
    private void SpawnRandomAnimalFromLeft()
    {
        int animalIndex = Random.Range(0, animalsPrefab.Length);
        Vector3 spawnPosition = new Vector3(LeftSpawnerPosition, 0, Random.Range(spawnRangeSides, spawnRangeSides+ spawnRangeSides));
        Instantiate(animalsPrefab[animalIndex], spawnPosition, Quaternion.Euler(0, 90, 0));
    }
    private void SpawnRandomAnimalFromRight()
    {
        int animalIndex = Random.Range(0, animalsPrefab.Length);
        Vector3 spawnPosition = new Vector3(RightSpawnerPosition, 0, Random.Range(spawnRangeSides, spawnRangeSides + spawnRangeSides));
        Instantiate(animalsPrefab[animalIndex], spawnPosition, Quaternion.Euler(0, -90, 0));
    }
}

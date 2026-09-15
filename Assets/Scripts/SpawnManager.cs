using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public InputAction spawnAction;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float spawnPosX = 23;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Score = 0");
        Debug.Log("Lives = 3");

        InvokeRepeating("spawnRandomAnimal", spawnDelay, spawnInterval);

        spawnAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnRandomAnimal()
    {
        // Spawn animals from Top
        int animalIndexTop = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosTop = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndexTop], spawnPosTop, animalPrefabs[animalIndexTop].transform.rotation);

        // Spawn animals from Left
        int animalIndexLeft = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosLeft = new Vector3(-spawnPosX, 0, Random.Range(-1, 16));
        Instantiate(animalPrefabs[animalIndexLeft], spawnPosLeft, animalPrefabs[animalIndexLeft].transform.rotation * Quaternion.Euler(0f, -90f, 0f));

        // Spawn animals from Right
        int animalIndexRight = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosRight = new Vector3(spawnPosX, 0, Random.Range(-1, 16));
        Instantiate(animalPrefabs[animalIndexRight], spawnPosRight, animalPrefabs[animalIndexRight].transform.rotation * Quaternion.Euler(0f, 90f, 0f));
    }
}

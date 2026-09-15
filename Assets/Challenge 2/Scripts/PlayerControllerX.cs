using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public InputAction fireAction;

    private float spawnCooldown = 1f;
    private float nextSpawnTime = 0f;


    // Start is called before the first frame update
    void Start()
    {
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (fireAction.triggered && Time.time >= nextSpawnTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            
            // Prevent spawn before spawnCooldown has passed
            nextSpawnTime = Time.time + spawnCooldown;
        }
    }
}

using UnityEngine;
using UnityEngine.UIElements;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float verticalBound = 24.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);

            GameManager.lives--;
    
            if (GameManager.lives <= 0)
            {
                Debug.Log("Lives = 0");
                Debug.Log("Game Over!");
            } else
            {
                Debug.Log("Lives = " + GameManager.lives);
            }
        } else if (transform.position.x > verticalBound)
        {
            Destroy(gameObject);

            GameManager.lives--;
    
            if (GameManager.lives <= 0)
            {
                Debug.Log("Lives = 0");
                Debug.Log("Game Over!");
            } else
            {
                Debug.Log("Lives = " + GameManager.lives);
            }
        } else if (transform.position.x < -verticalBound)
        {
            Destroy(gameObject);
            
            GameManager.lives--;
    
            if (GameManager.lives <= 0)
            {
                Debug.Log("Lives = 0");
                Debug.Log("Game Over!");
            } else
            {
                Debug.Log("Lives = " + GameManager.lives);
            }
        }
    }
}

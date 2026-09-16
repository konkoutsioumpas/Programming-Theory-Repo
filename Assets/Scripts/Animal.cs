using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour
{
    [SerializeField] private Slider hungerSlider;
    private int currentFedAmount = 0;

    // ENCAPSULATION
    private float speed = 40.0f;
    protected float Speed
    {
        get { return speed; }
        set
        {
            if (value > 0)
            {
                speed = value;
            }
            else
            {
                Debug.LogError("Speed must be greater than 0.");
            }
        }
    }

    // ENCAPSULATION
    private int foodNeeded = 3;
    protected int FoodNeeded
    {
        get { return foodNeeded; }
        set
        {
            if (value > 0)
            {
                foodNeeded = value;
            }
            else
            {
                Debug.LogError("Food needed must be greater than 0.");
            }
        }
    }

    // POLYMORPHISM
    protected virtual void Start()
    {
        hungerSlider.maxValue = foodNeeded;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward(speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.lives--;

            if (GameManager.lives <= 0)
            {
                Debug.Log("Lives = 0");
                Debug.Log("Game Over!");
            }
            else
            {
                Debug.Log("Lives = " + GameManager.lives);
            }
        }
        else
        {
            FeadAnimal();
            Destroy(other.gameObject);
        }
    }

    // ABSTRACTION
    void FeadAnimal()
    {
        currentFedAmount++;

        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;

        if (currentFedAmount >= foodNeeded)
        {
            Destroy(gameObject);

            GameManager.score += 1;
            Debug.Log("Score = " + GameManager.score);
        }
    }

    // ABSTRACTION
    void MoveForward(float moveSpeed)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}

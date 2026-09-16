using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
  public int foodNeeded = 3;
  public Slider hungerSlider;
  private int currentFedAmount = 0;

  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    hungerSlider.maxValue = foodNeeded;
    hungerSlider.value = 0;
    hungerSlider.fillRect.gameObject.SetActive(false);
  }

  // Update is called once per frame
  void Update()
  {
      
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
      } else
      {
        Debug.Log("Lives = " + GameManager.lives);
      }
    } else
    {
      // foodNeeded--;

      // if (foodNeeded == 0)
      // {
      //   Destroy(gameObject);
      // }
      FeadAnimal();
      Destroy(other.gameObject);

      // GameManager.score += 1;
      // Debug.Log("Score = " + GameManager.score);
    }
  }

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
}

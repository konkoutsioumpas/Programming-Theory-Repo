using UnityEngine;

// INHERITANCE
public class Fox : Animal
{
    // POLYMORPHISM
    protected override void Start()
    {
        Speed = 5f;
        FoodNeeded = 1;
        base.Start();
    }
}

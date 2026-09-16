using UnityEngine;

// INHERITANCE
public class Stag : Animal
{
    // POLYMORPHISM
    protected override void Start()
    {
        Speed = 10f;
        FoodNeeded = 2;
        base.Start();
    }
}

using UnityEngine;

// INHERITANCE
public class Moose : Animal
{
    // POLYMORPHISM
    protected override void Start()
    {
        Speed = 15f;
        FoodNeeded = 3;
        base.Start();
    }
}

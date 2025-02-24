using UnityEngine;

public class Potion : Item
{
    public Potion(string name) : base(name)
    {
    }

    public void Use(int value) => Debug.Log($"Potion {name} used {value} point.");
}
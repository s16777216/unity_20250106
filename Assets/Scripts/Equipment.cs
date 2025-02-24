using UnityEngine;

public class Equipment : Item
{
    public Equipment(string name) : base(name)
    {
    }

    public override void Use()
    {
        Debug.Log($"Equipment {name} used.");
    }
}
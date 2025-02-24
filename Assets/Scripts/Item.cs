using UnityEngine;

public class Item
{
    protected string name;

    public Item(string name)
    {
        this.name = name;
    }

    public virtual void Use()
    {
        Debug.Log($"Item {name} used.");
    }
}
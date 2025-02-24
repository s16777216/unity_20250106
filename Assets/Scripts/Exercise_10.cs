using UnityEngine;

public class Exercise_10 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var redPotion = new Potion("¬õ¤ô");
        var bluePotion = new Potion("ÂÅ¤ô");
        var helmet = new Equipment("ÀY²¯");

        redPotion.Use();
        bluePotion.Use(999);
        helmet.Use();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

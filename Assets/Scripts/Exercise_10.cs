using UnityEngine;

public class Exercise_10 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var redPotion = new Potion("����");
        var bluePotion = new Potion("�Ť�");
        var helmet = new Equipment("�Y��");

        redPotion.Use();
        bluePotion.Use(999);
        helmet.Use();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

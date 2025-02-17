using UnityEngine;

public class Exercise_8_class : MonoBehaviour
{
    Boss boss1 = new Boss("boss1", "ult1", 100f);
    Boss boss2 = new Boss("boss2", "ult2", 123.456f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boss1.Info();
        boss2.Info();
    }
}

using UnityEngine;

public class Exercise_3_Operator : MonoBehaviour
{
    public void Awake()
    {
        Debug.Log(Calc());
    }

    private int Calc()
    {
        return 6 / 2 * (1 + 2);
    }
}

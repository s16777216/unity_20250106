using UnityEngine;

public class Class_15_Generic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a = 1, b = 2;
        Debug.Log($"a: {a}, b: {b}");
        SwapNumber(ref a, ref b);
        Debug.Log($"a: {a}, b: {b}");

        char c = 'A', d = 'B';
        Debug.Log($"c: {c}, d: {d}");
        SwapChar(ref c, ref d);
        Debug.Log($"c: {c}, d: {d}");
    }

    void SwapNumber(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    void SwapChar(ref char a, ref char b)
    {
        char temp = a;
        a = b;
        b = temp;
    }

    void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}

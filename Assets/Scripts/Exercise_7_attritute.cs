using UnityEngine;

public class Exercise_7_attritute : MonoBehaviour
{
    private float _hp = 100.0f;

    public float hp
    {
        get
        {
            if (_hp <= 0) 
                Debug.Log("");
            return _hp;
        }
    }
}

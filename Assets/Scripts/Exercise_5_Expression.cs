using UnityEngine;

public class Exercise_5_Expression : MonoBehaviour
{
    [Range(0, 100)]
    [Tooltip("��q")]
    public int hp;

    // Update is called once per frame
    void Update()
    {
        switch (hp)
        {
            case >= 80:
                Debug.Log("��q�w��");
                break;
            case >= 60:
                Debug.Log("���d���A�����p");
                break;
            case >= 40:
                Debug.Log("ĵ�i, �ֳܤ�!");
                break;
            case >= 10:
                Debug.Log("�֦����F");
                break;
            case 0:
                Debug.Log("�A�w�g���F");
                break;
        }
    }
}

using UnityEngine;

public class Exercise_6_Loop_Array : MonoBehaviour
{
    private string[,,] arrays =
    {
        {
            { "�֥d�C", "�p�C", "�p���s" }, { "����ؤl", "�P�Ůy", "�֥�" }
        },
        {
            { "�짯", "��ۣۣ", "ۣۣ�_��" }, { "���_", "�Ť��F", "��ۣۣ" }
        },
        {
            { "���Y�H", "����", "���" }, { "�Ʈ洵", "�\��", "�p�k�v" }
        }
    };

    private void Awake()
    {
        string aws1 = arrays[0, 0, 0];

        Debug.Log(aws1);

        string aws2 = arrays[1, 0, 2];

        Debug.Log(aws2);

        string aws3 = arrays[2, 1, 1];

        Debug.Log(aws3);

        string aws4 = arrays[2, 1, 3];

        Debug.Log(aws4);
    }
}

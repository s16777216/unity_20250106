using UnityEngine;

public class Class_3_Operator: MonoBehaviour
{
    #region ������ݩ�
    // C# �ܼ� - ��� Field
    // ����ݩ� Field Attribute
    // [���D(���D��r)]: �b�ݩʭ��O�W��ܤ�r
    [Header("����")]
    public int level = 1;

    // [����(���ܤ�r)]: �b�ݩʭ��O�ƹ����d�b�ܼƤW���
    [Tooltip("�o�O���⪺���ʳt��, ����ĳ�W�L100.")]
    public float movement = 2.5f;

    // [�d��(�̤p, �̤j)]: ���ƭ������K�[�d��(���O�W�אּ�Ʊ�)
    [Range(0, 100)]
    public byte count = 10;

    // �d�򤣯�ϥΦb�D�ƭ������W
    [Range(0, 100)]
    public string weapon = "�P��";

    [TextArea(1, 3)]
    public string description = "Deasdasdasdasasd";
    #endregion

    #region �ƥ�
    // https://docs.unity3d.com/6000.0/Documentation/Manual/execution-order.html
    // �ϥ�Unity�ƥ�, �����O�����~��MonoBehavior

    // ����ƥ�: ����C����|���檺�Ĥ@�Өƥ�, �u����@��
    private void Awake()
    {
        // Ctrl + Shift + C �}��Console���O
        Debug.Log("Hello world!!!!");
        Debug.Log("<color=red>red text</color>");
    }
    #endregion
}

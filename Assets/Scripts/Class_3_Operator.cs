using UnityEngine;

public class Class_3_Operator: MonoBehaviour
{
    #region 基本欄位屬性
    // C# 變數 - 欄位 Field
    // 欄位屬性 Field Attribute
    // [標題(標題文字)]: 在屬性面板上顯示文字
    [Header("等級")]
    public int level = 1;

    // [提示(提示文字)]: 在屬性面板滑鼠停留在變數上顯示
    [Tooltip("這是角色的移動速度, 不建議超過100.")]
    public float movement = 2.5f;

    // [範圍(最小, 最大)]: 幫數值類型添加範圍(面板上改為滑桿)
    [Range(0, 100)]
    public byte count = 10;

    // 範圍不能使用在非數值類型上
    [Range(0, 100)]
    public string weapon = "匕首";

    [TextArea(1, 3)]
    public string description = "Deasdasdasdasasd";
    #endregion

    #region 事件
    // https://docs.unity3d.com/6000.0/Documentation/Manual/execution-order.html
    // 使用Unity事件, 此類別必須繼承MonoBehavior

    // 喚醒事件: 撥放遊戲後會執行的第一個事件, 只執行一次
    private void Awake()
    {
        // Ctrl + Shift + C 開啟Console面板
        Debug.Log("Hello world!!!!");
        Debug.Log("<color=red>red text</color>");
    }
    #endregion
}

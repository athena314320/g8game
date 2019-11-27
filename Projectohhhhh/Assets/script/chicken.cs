using UnityEngine;

public class chicken : MonoBehaviour
{
#region 欄位區域
    //宣告變數 (定義欄位 Field)
    //修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    //私人 - 隱藏 private (預設)
    //公開 - 顯示 public 
    [Header("移動速度")] [Range(1, 100)]
    public int speed = 10;
    [Header("旋轉速度"),Tooltip("G8雞的旋轉速度"), Range(1.5f, 200f)]
    public float turn = 20.5f;
    [Header("是否完成任務")]
    public bool mission;
    [Header("玩家名稱")]
    public string name = "G8雞";
    #endregion

    #region 方法區域
    ///<summary>
    ///跑步
    ///</summary>
    private void Run() 
    {

    }

    ///<summary>
    ///旋轉
    ///</summary>
    private void Turn()
    {

    }

    ///<summary>
    ///亂叫
    ///</summary>
    ///
    private void Bark()
    {

    }
    ///<summary>
    ///撿東西
    ///</summary>
    
    private void Catch()
    {

    }

    ///<summary>
     ///檢視任務
     ///</summary>
    private void Task()
    {

    }
    #endregion
}
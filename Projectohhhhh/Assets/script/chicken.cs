using UnityEngine;

public class chicken : MonoBehaviour
{
#region 欄位區域
    //宣告變數 (定義欄位 Field)
    //修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    //私人 - 隱藏 private (預設)
    //公開 - 顯示 public 
    [Header("移動速度")] [Range(1, 5000)]
    public int speed = 2000;         //整數1.999-100
    [Header("旋轉速度"),Tooltip("G8雞的旋轉速度"), Range(1.5f, 500f)]
    public float turn = 20.5f;     //浮點數
    [Header("是否完成任務")]
    public bool mission;           //布林直 True False
    [Header("玩家名稱")]
    public string name = "G8雞";   //字串 ""
    #endregion

    public Transform tran;
    public Rigidbody rig;
    public Animator ani;

    private void Update()
    {
       Turn();
        Run();
    }

    #region 方法區域
    ///<summary>
    ///跑步
    ///</summary>
    private void Run() 
    {
        float v = Input.GetAxis("Vertical");  // W上 1 , S下 -1 , 沒按0
        //rig.Addforce(0, 0, speed * v);      //世界座標
        //tran.forward 區域座標 z軸
        //tran.right   區域座標 x軸
        //tran.up      區域座標 y軸
        rig.AddForce(tran.forward * speed * v * Time.deltaTime); //區域座標
    }

    ///<summary>
    ///旋轉
    ///</summary>
    private void Turn()
    {
        float h = Input.GetAxis("Horizontal");     //A 左 -1 . D 右 1 . 沒按0
        tran.Rotate(0, turn * h* Time.deltaTime, 0 );
    }

    ///<summary>
    ///亂叫
    ///</summary>
    ///
    private void Bark()
    {
        //按下空白鍵拍翅膀
        print(Input.GetKeyDown(KeyCode.Space));
    }
    ///<summary>
    ///撿東西
    ///</summary>
    
    private void Catch()
    {
        //按下左鍵撿東西
        print(Input.GetMouseButton(0));
    }

    ///<summary>
    ///檢視任務
    ///</summary>
    private void Task()
    {

    }
    #endregion
}
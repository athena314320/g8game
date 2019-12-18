using UnityEngine;

public class chicken : MonoBehaviour
{
    #region 欄位區域
    //宣告變數 (定義欄位 Field)
    //修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    //私人 - 隱藏 private (預設)
    //公開 - 顯示 public 
    [Header("移動速度")]
    [Range(1, 5000)]
    public int speed = 2000;         //整數1.999-100
    [Header("旋轉速度"), Tooltip("G8雞的旋轉速度"), Range(1.5f, 500f)]
    public float turn = 20.5f;     //浮點數
    [Header("是否完成任務")]
    public bool mission;           //布林直 True False
    [Header("玩家名稱")]
    public string name = "G8雞";   //字串 ""
    #endregion

    public Transform tran;
    public Rigidbody rig;
    public Animator ani;
    public AudioSource aud;

    public AudioClip soundBark;

    private void Update()
    {
        Turn();
        Run();
        Bark();
        Catch();
    }

    #region 方法區域
    ///<summary>
    ///跑步
    ///</summary>
    private void Run()
    {
        //如果 動畫 為 撿東西 就 跳出
        if (ani.GetCurrentAnimatorStateInfo(0).IsName("撿東西")) return;

        float v = Input.GetAxis("Vertical");  // W上 1 , S下 -1 , 沒按0
        //rig.Addforce(0, 0, speed * v);      //世界座標
        //tran.forward 區域座標 z軸
        //tran.right   區域座標 x軸
        //tran.up      區域座標 y軸
        rig.AddForce(tran.forward * speed * v * Time.deltaTime); //區域座標

        ani.SetBool("走路開關", v != 0);
    }

    ///<summary>
    ///旋轉
    ///</summary>
    private void Turn()
    {
        float h = Input.GetAxis("Horizontal");     //A 左 -1 . D 右 1 . 沒按0
        tran.Rotate(0, turn * h * Time.deltaTime, 0);
    }

    ///<summary>
    ///亂叫
    ///</summary>
    ///
    private void Bark()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetTrigger("拍翅膀觸發器");

            aud.PlayOneShot(soundBark, 10f);
        }
            //按下空白鍵拍翅膀
           
    }
    ///<summary>
    ///撿東西
    ///</summary>

    private void Catch()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ani.SetTrigger("撿東西觸發器");
        }
        //按下左鍵撿東西

    }

    ///<summary>
    ///檢視任務
    ///</summary>
    private void Task()
    {

    }
    #endregion
}
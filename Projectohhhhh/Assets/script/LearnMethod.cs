using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    public void Drive(int SPEED)
    {
        print("音效~");
        print("開車，時速" + SPEED);

    }

    public void Start()
    {
        print("哈瞜~沃德");
        Drive(200);
        Drive(300);
        Drive(400);
    }



}

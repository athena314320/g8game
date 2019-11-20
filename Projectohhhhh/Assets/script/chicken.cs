using UnityEngine;

public class chicken : MonoBehaviour
{
    [Header("移動速度")] [Range(1, 100)]
    public int speed = 10;
    [Tooltip("G8雞的旋轉速度")]
    public float turn = 20.5f;
    public bool mission;
    public string name = "G8雞";

}

using UnityEngine;

public class Learnif : MonoBehaviour
{
    public bool opendoor;
    public int score = 100;
    public int attack = 200;

    private void Start()
    
    {
        //語法:  if  ( 布林值 ) { 陳述式或演算法 }
        //()內的布林值為true執行{}
        if (true)
        {
            print("測試");
        }

    }
   

    private void Update()
    {

        //if()內的布林值為true執行if{}
        if (opendoor)
        {
            print("開門");
        }
        //if()內的布林值為false執行if{}
        else
        {
            print("關門");
        }

        if (attack >= 50 && attack<100)
        {
            print("攻擊兩倍");
        }

        else if (attack >= 100 && attack < 150)
        {
            print("攻擊五倍");
        }

        else if (attack>= 150 )
        {
            print("攻擊十倍");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    private int hp = 100;                                   //변수 hp를 private 하게 선언 100 입력
    private int Power = 50;                                 //변수 power를 private 하게 선언 50 입력

    public void Attack()                                    //메서드 Damage 생성
    {
        Debug.Log(this.Power + " 데미지를 입혔다.");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + " 데미지를 입었다.");
    }

    public int GetHp()
    {
        return hp;
    }
}


public class Test_008 : MonoBehaviour
{
    public Text playerHp;
    public Text player2Hp;

    Player mPlayer = new Player();                      // 클래스 생성 New <===
    Player mPlayer2 = new Player();

    // Start is called before the first frame update
    void Start()
    {                          
        //mPlayer.Attack();                               //Player 메서드 Attack 호출                             
        //mPlayer.Damage(30);                             //Player 메서드 Damage 호출
        //Debug.Log(mPlayer.GetHp());                     //Player의 Hp를 보여준다.
    }

    // Update is called once per frame
    void Update()
    {
        playerHp.text = "Player1 Hp : " + mPlayer.GetHp().ToString();     //Player의 Hp를 UI로 표시
        player2Hp.text = "Player2 Hp : " + mPlayer2.GetHp().ToString();     //Player의 Hp를 UI로 표시

        if (Input.GetMouseButtonDown(0))
        {
            mPlayer.Damage(1);                          //Player 메서드 Damage 호출
        }

        if (Input.GetMouseButtonDown(1))
        {
            mPlayer2.Damage(1);                          //Player 메서드 Damage 호출
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    private int hp = 100;                                   //���� hp�� private �ϰ� ���� 100 �Է�
    private int Power = 50;                                 //���� power�� private �ϰ� ���� 50 �Է�

    public void Attack()                                    //�޼��� Damage ����
    {
        Debug.Log(this.Power + " �������� ������.");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + " �������� �Ծ���.");
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

    Player mPlayer = new Player();                      // Ŭ���� ���� New <===
    Player mPlayer2 = new Player();

    // Start is called before the first frame update
    void Start()
    {                          
        //mPlayer.Attack();                               //Player �޼��� Attack ȣ��                             
        //mPlayer.Damage(30);                             //Player �޼��� Damage ȣ��
        //Debug.Log(mPlayer.GetHp());                     //Player�� Hp�� �����ش�.
    }

    // Update is called once per frame
    void Update()
    {
        playerHp.text = "Player1 Hp : " + mPlayer.GetHp().ToString();     //Player�� Hp�� UI�� ǥ��
        player2Hp.text = "Player2 Hp : " + mPlayer2.GetHp().ToString();     //Player�� Hp�� UI�� ǥ��

        if (Input.GetMouseButtonDown(0))
        {
            mPlayer.Damage(1);                          //Player �޼��� Damage ȣ��
        }

        if (Input.GetMouseButtonDown(1))
        {
            mPlayer2.Damage(1);                          //Player �޼��� Damage ȣ��
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_004 : MonoBehaviour
{
    public int hp = 180;
    public Text textUI;
    public Text hpTextUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            hp += 10;
        }
        if (Input.GetMouseButtonDown(1))
        {
            hp -= 10;
        }
        
            if (hp <= 50)
        {
            Debug.Log("도망 !");          //50이하일때
            textUI.text = "도망 !";
        }
        else if (hp >= 200)
        {
            Debug.Log("공격 !");          //200이상일때
            textUI.text = "공격 !";
        }
        else if (hp <= 200)
        {
            Debug.Log("방어 !");
            textUI.text = "방어 !";
        }

        hpTextUI.text = "HP :" + hp.ToString();
    }
}

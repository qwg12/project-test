using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_003 : MonoBehaviour
{
    public int herbNum = 1;                    //���� herNum �����Ŀ� 1�� �Է�

    void Start()
    {
        

            if (herbNum == 1)               //���ǽ� herNum �� 1�� ��� �ȿ� ������ �����Ѵ�.
        {
            Debug.Log("ü���� 50 ȸ��");    //Console.log â�� ������ ������ ��� �ش� ������ ǥ���Ѵ�.
        }
        else
        {
            Debug.Log("ü�� -50 ");         //Console,log â�� ������ ������ ��� �ش� ������ ǥ���Ѵ�,
        }
        
    }

    
}

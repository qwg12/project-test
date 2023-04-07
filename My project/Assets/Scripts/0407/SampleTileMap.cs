using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleTileMap : MonoBehaviour
{
    public GameObject tile;                 //타일 게임 오브젝트 선언

    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i < 10; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                GameObject temp = (GameObject)Instantiate(tile);    //prefabs or Object를 instantiate 함수로 생성하고 temp에 입력
                temp.transform.position = new Vector3(i, 0, j);     //생성된 Tile을 원하는 위치에 배치한다.
            }
        }
    }

}

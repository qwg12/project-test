using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastController : MonoBehaviour
{
    public GameObject Monser;
 
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if(Physics.Raycast(cast, out hit))      //Rast 가 충돌 감지된것을 hit로 돌려준다.
            {
                if(hit.collider.tag == "Ground")        //Tag 가 땅일 때
                {
                    GameObject temp = (GameObject)Instantiate(Monser);  //몬스터 피리맵을 생성 하겠다.
                    temp.transform.position = hit.point + new Vector3(0.0f, 1.0f, 0.0f);                //Ray 충돌 위치에
                }
  
                Debug.Log(hit.collider.name);       //오브젝트 이름을 출력
                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);        
            }
        }
    }
}

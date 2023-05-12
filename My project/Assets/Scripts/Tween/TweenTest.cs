using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTest : MonoBehaviour
{
    public bool isPunch = false;

    Sequence sequence;
    // Start is called before the first frame update
    void Start()
    {
        //transform.DOMoveX(5, 2);            //x축으로 5만큼 2초 동안 이동
        //transform.DORotate(new Vector3(0, 0, 180), 2); //Z축으로 180도 회전
        //transform.DOScale(new Vector3(2, 2, 2), 2); //2배로 2초동안

        //Sequence sequence = DOTween.Sequence();
        //sequence.Append(transform.DOMoveX(5, 2).SetEase(Ease.OutBounce));
        //sequence.Append(transform.DORotate (new Vector3(0, 0, 180), 2));
        //sequence.Append(transform.DOScale(new Vector3(2, 2, 2), 2).OnComplete(SequenceEnd));
        //sequenceLoop.Kill();

        //Sequence sequence = DOTween.Sequence();
        //sequence.Append(transform.DOMoveX(5, 2).SetEase(Ease.OutBounce));
        //sequence.SetLoops(-1, LoopType.Yoyo);

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!isPunch)
            {
                isPunch = true;
                transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1).OnComplete(EndPunch);
            }
        }
    }

    void EndPunch()
    {
        isPunch = false;
    }



}

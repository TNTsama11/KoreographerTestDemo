using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;
using DG.Tweening;

public class LightBar : MonoBehaviour
{
    public Transform[] light1;
    public Transform[] light2;
    public Transform[] light3;

    private int lastHalf;
    private int lastQuarter;
    private int lastEight;

    void Start()
    {
        
    }

    void Update()
    {
        int curHalf = Mathf.FloorToInt(Koreographer.GetBeatTime(null, 1));
        if (curHalf != lastHalf)
        {
           
            Half(0.15f);
            lastHalf = curHalf;
        }


        int curQuater= Mathf.FloorToInt(Koreographer.GetBeatTime(null, 2));
        if (curQuater != lastQuarter)
        {
            Quater(0.1f);
            lastQuarter = curQuater;
        }


        int curEight = Mathf.FloorToInt(Koreographer.GetBeatTime(null, 1));
        {
            if (curEight != lastEight)
            {
                Eight(0.05f);
                lastEight = curEight;
            }

        }
    }

    private void Half(float x)
    {
        foreach(var item in light1)
        {
            item.localScale = new Vector3(x, 0.02f, 0.02f);
            item.DOScaleX(0.25f, 0.2f);
        }
    }

    private void Quater(float x)
    {
        foreach (var item in light2)
        {
            item.localScale= new Vector3(x, 0.02f, 0.02f);
            item.DOScaleX(0.2f, 0.2f);
        }
    }

    private void Eight(float x)
    {
        foreach (var item in light3)
        {
            item.localScale= new Vector3(x, 0.02f, 0.02f);
            item.DOScaleX(0.15f, 0.2f);
        }
    }
}

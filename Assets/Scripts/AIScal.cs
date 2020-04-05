using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;
using DG.Tweening;

public class AIScal : MonoBehaviour
{

    private int lastQuarter;

    void Awake()
    {
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        int curQuater = Mathf.FloorToInt(Koreographer.GetBeatTime(null, 1));
        if (curQuater != lastQuarter)
        {
            Quater();
            lastQuarter = curQuater;
        }
    }

    private void Quater()
    {
        this.transform.DOScaleY(1.5f, 0.2f).OnComplete(()=> 
        {
            this.transform.DOScaleY(1f, 0.2f);
        });
    }
}

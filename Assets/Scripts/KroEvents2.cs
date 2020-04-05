using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class KroEvents2 : MonoBehaviour
{
    public string eventID;

    float minScale = 0.5f;
    float maxScale = 1.5f;

    void Start()
    {
        Koreographer.Instance.RegisterForEventsWithTime(eventID, Test2);
    }

    void Update()
    {
        
    }

    public void Test2(KoreographyEvent koreographyEvent,int sampleTime,int sampleDelta,DeltaSlice deltaSlice)
    {
        Debug.Log(2);
        if (koreographyEvent.HasCurvePayload())
        {
            float curveValue = koreographyEvent.GetValueOfCurveAtTime(sampleTime);
            transform.localScale = Vector3.one * Mathf.Lerp(minScale, maxScale, curveValue);
        }
    }
}

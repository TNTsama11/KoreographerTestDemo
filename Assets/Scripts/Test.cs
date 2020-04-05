using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class Test : MonoBehaviour
{
    public int sub;
    private int lastQuarterNote = 0;
    private int lastEighthNote = 0;
    
    void Awake()
    {
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        int curQuarterNote = Mathf.FloorToInt(Koreographer.GetBeatTime(null,sub));
        if (curQuarterNote != lastQuarterNote)
        {
            LeftUp();
            lastQuarterNote = curQuarterNote;
        }
    }

    private void LeftUp()
    {
        this.GetComponent<Rigidbody>().AddForce(Vector3.up*2f, ForceMode.Impulse);
    }
}

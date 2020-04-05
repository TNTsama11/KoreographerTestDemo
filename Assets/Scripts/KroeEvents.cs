using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class KroeEvents : MonoBehaviour
{
    public string eventID;
    private Rigidbody myRigidbody;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        Koreographer.Instance.RegisterForEvents(eventID, Test);
    }

    void Update()
    {
        
    }

    private void Test(KoreographyEvent koreographyEvent)
    {
        myRigidbody.AddForce(Vector3.up*5f, ForceMode.Impulse);
    }
}

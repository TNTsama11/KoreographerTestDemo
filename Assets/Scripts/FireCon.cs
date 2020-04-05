using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;
using System;

public class FireCon : MonoBehaviour
{
    public string eventsID;
    public GameObject bullet;
    public AudioClip shoot;

    void Awake()
    {
        
    }

    void Start()
    {
        Koreographer.Instance.RegisterForEvents(eventsID, Fire);
    }

    private void Fire(KoreographyEvent koreoEvent)
    {
        GameObject go = Instantiate(bullet, this.transform.position, this.transform.rotation);
        AudioSource.PlayClipAtPoint(shoot, this.transform.position);
    }

    void Update()
    {
        
    }


}

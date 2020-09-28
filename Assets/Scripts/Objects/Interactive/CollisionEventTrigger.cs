﻿using UnityEngine;
using UnityEngine.Events;

using System;
using System.Collections;

[Serializable]
public class MyEvent : UnityEvent<string, GameObject> { }

public class CollisionEventTrigger : MonoBehaviour
{

    public MyEvent myEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.tag);
        if (collision.tag == "Player")
        {
            myEvent.Invoke("hello world", gameObject); 
            // can be used to send dynamic stuff like .SendMessage()
            // use myEvent.Invoke("ApplyDamage", gameObject) and config to .SendMessage()
            // to run .SendMessage("ApplyDamage", gameObject) when invoked.
        }
    }

    public void TestPrint(string s, GameObject g)
    {
        if (g != null)
            Debug.Log(g.name + " says: " + s);
    }
}
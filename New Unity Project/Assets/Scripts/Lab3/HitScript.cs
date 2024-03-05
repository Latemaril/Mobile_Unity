using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        PlayerLab3 player = GameObject.Find("FirstPersonCharacter").GetComponent<PlayerLab3>();
        
        player._hitCount = player._hitCount + 1;
        
        Text count = GameObject.Find("Count").GetComponent<Text>();
        count.text = "Score: " + player._hitCount;
        Destroy(gameObject);
    }
}

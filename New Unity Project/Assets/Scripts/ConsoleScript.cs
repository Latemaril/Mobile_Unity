using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleScript : MonoBehaviour
{
    public int age = 500;
 
    void Start()
    {
        Debug.Log("Дарова попущи! Мне " + age + " лет");
    }


    void Update()
    {
        float sinus = Mathf.Sin(Time.time);
        float d = Mathf.Abs(sinus);
        float t = Mathf.Lerp(1, 2, d);

        transform.Rotate(0, 0.5f, 0);
        transform.localScale = new Vector3(t, t, t);
    }
}

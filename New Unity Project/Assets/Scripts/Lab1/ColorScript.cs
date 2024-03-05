using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{

    public Color color;

    void Start()
    {

        MeshRenderer mesh = GetComponent<MeshRenderer>();
        mesh.material.color = color;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

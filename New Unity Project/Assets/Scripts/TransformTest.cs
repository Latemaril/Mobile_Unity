using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    GameObject[] transfromCubes;
    // Start is called before the first frame update
    void Start()
    {
        transfromCubes = GameObject.FindGameObjectsWithTag("TransformTest");

        for (int i = 0; i < transfromCubes.Length; i++)
        {
            transfromCubes[i].transform.position = new Vector3((-40 + (i*2)), 0.5f, 0);
            Debug.Log("transfromCubes[i].transform.position  " + transfromCubes[i].transform.position);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

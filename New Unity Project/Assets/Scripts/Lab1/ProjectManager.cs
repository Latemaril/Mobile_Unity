using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectManager : MonoBehaviour

{
    GameObject[] myCubes;
    public GameObject cubePrefab;

    public void setScale(int scale, GameObject myCube)
    {
        myCube.transform.localScale = new Vector3(scale, scale, scale);
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i % 10 == 0)
            {
                for (int j = 0; j < 10; j++)
                {
                    Instantiate(cubePrefab, new Vector3(60 + (j * 2), 0, -1 - (i / 10 * 2)), Quaternion.identity);
                }
            }
        }

        myCubes = GameObject.FindGameObjectsWithTag("MyCube");
        Debug.Log("В сцене " + myCubes.Length + " кубов MyCube");
        Debug.Log("Тип " + myCubes[0].GetType());

        for (int i  = 0; i < myCubes.Length; i++)
        {
            setScale(2, myCubes[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void onMyButtonClick()
    {
        Debug.Log("Ты зачем на меня тыкнул, чеееееел?????");
    }
}

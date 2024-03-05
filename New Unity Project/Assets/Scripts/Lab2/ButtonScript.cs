using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    private int count;
    private Text myText;
    public GameObject infoWindow;
    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("1").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onMyButtonClick()
    {
        Debug.Log("Ты зачем на меня тыкнул, чеееееел?????");
        infoWindow.SetActive(true);
    }

    public void windowClose()
    {
        infoWindow.SetActive(false);
    }

    public void onMyButtonClickCount()
    {
        ++count;
        myText.text = count.ToString();
        Debug.Log(count);
    }
}

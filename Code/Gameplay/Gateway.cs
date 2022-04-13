using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gateway : MonoBehaviour
{

    [Header("Gateway")]
    GameManager managerObject;
    public int gatwayStatus;
    public GameObject gatwayText, losePanel;

    private void Start()
    {
        managerObject = FindObjectOfType<GameManager>();
    }
    private void Update()
    {
        gatwayText.GetComponent<Text>().text = "" + gatwayStatus;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bit")
        {
            if (col.gameObject.GetComponent<Bit>().bitStatus == gatwayStatus)
            {
                managerObject.Addscore();
            }
            else
            {
                col.gameObject.GetComponent<Animator>().Play("Bit");
                Time.timeScale = 0f;
                Handheld.Vibrate();
                losePanel.SetActive(true);
            }
        }
        else
        {

            if (col.gameObject.GetComponent<Bit>().bitStatus != gatwayStatus)
            {
                managerObject.Addscore();   
            }
            else
            {
                col.gameObject.GetComponent<Animator>().Play("Bit");
                Time.timeScale = 0f;
                
                losePanel.SetActive(true);
               
            }
        }
    }
    
}

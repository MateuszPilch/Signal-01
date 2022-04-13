using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
   public GameObject gatwayObject;

    public void OnHeldButton()
    {
        if (Time.timeScale == 1f)
        {
            gatwayObject.GetComponent<Gateway>().gatwayStatus = 1;
        }
        
    }
    public void OnReleseButton()
    {
        if (Time.timeScale == 1f)
        {
            gatwayObject.GetComponent<Gateway>().gatwayStatus = 0;
        }
    }
}

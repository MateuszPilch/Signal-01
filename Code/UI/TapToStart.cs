using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToStart : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0f;
    }
    public void OnTap()
    {
        GetComponent<Animator>().Play("TapToStart"); 
    }
    public void TapTime()
    {
        Time.timeScale = 1f;
    }
}

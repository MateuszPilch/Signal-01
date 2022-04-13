using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logo : MonoBehaviour
{
    public string[] texts;
    public GameObject shadowObject;
    public float timeToChange;

    private void Update()
    {
        timeToChange += Time.deltaTime;
        int ranInt = Random.Range(0, texts.Length);

        if (timeToChange > 0.1f)
        {
            GetComponent<Text>().text = "SIGNAL " + texts[ranInt];
            shadowObject.GetComponent<Text>().text = "SIGNAL " + texts[ranInt];
            timeToChange = 0f;
        } 
    }
}

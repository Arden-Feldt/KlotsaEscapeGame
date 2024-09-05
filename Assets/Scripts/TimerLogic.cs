using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLogic : MonoBehaviour
{
    public float time;
    private float startTime;
    public Text timeText;

    
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.time - startTime;
        timeText.text = time.ToString("F2");
    }
}

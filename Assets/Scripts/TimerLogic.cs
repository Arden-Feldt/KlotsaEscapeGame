using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLogic : MonoBehaviour
{
    public float time;
    private float startTime;
    public Text timeText;
    public bool endState;

    
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        startTime = Time.time;
        endState = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (endState){
            time = Time.time - startTime;
            timeText.text = time.ToString("F2");
        }
    }
}

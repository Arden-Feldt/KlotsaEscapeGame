using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class EscapeeMove : MonoBehaviour
{
    public GameObject escapee;
    public GameObject pylon;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        escapee.transform.position = Vector3.MoveTowards(escapee.transform.position, pylon.transform.position, speed);
    }
}

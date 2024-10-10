using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignPylon : MonoBehaviour
{
    public GameObject pylon;
    
    
    // Start is called before the first frame update
    void Start()
    {
        // Find all EscapeePrefabs in the scene
        EscapeePrefab[] escapees = FindObjectsOfType<EscapeePrefab>();

        // Loop through each EscapeePrefab and assign the Pylon
        foreach (EscapeePrefab escapee in escapees)
        {
            escapee.Pylon = pylon;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

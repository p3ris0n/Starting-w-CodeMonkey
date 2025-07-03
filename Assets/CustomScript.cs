using System.Diagnostics;
using UnityEngine;

public class CustomScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UnityEngine.Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
       UnityEngine.Debug.Log("stop");
    }
}

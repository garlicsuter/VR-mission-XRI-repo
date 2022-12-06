using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyControls : MonoBehaviour
{
    public GameObject spawnObject1;
    private GameObject spawnLoc1;
    
    public void spawnObj1()
    {
        Instantiate(spawnObject1, spawnLoc1.transform.position, Quaternion.identity);
    }

    public void Button2Stage()
    {
        Debug.Log("2 Stage Button Pressed");
    }

    public void Button2StageChanged()
    {
        Debug.Log("2 Stage Button Changed");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

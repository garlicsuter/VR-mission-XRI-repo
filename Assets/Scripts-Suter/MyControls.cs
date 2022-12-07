using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XRContent.Interaction;

public class MyControls : MonoBehaviour
{
    public GameObject spawnObject1;
    public GameObject spawnLoc1;
    public GameObject myXRKnobContainer;
    public float theValue;
    public int myIntValue;


    // Start is called before the first frame update
    void Start()
    {
        //Read the value of the XRKnob
        //theValue = myXRKnobContainer.GetComponent<Unity.XRContent.Interaction.XRKnob>().Value;
        //Debug.Log("XRKnob's value is: " + theValue);
    }

    //public void KnobValueCheck()
    //{
    //    //ran on Value Change of dial
    //    theValue = myXRKnobContainer.GetComponent<XRKnob>().Value;
    //    //Debug.Log("Dial Turned. New KnobValue = " + theValue);
    //}

    public void spawnObj1()
    {
        Instantiate(spawnObject1, spawnLoc1.transform.position, Quaternion.identity);
        Debug.Log("1 Stage Button Pressed");
    }

    public void SpawnKnobObjs()
    {
        
        //Determine the raw value of the knob position, it's "value"
        theValue = myXRKnobContainer.GetComponent<XRKnob>().Value;

        if(theValue == 0)
        {
            myIntValue = 0;
        }

        else if (theValue == 0.25f)
        {
            myIntValue = 1;
        }

        else if (theValue == 0.50f)
        {
            myIntValue = 2;
        }

        else if (theValue == 0.75f)
        {
            myIntValue = 3;
        }

        else if (theValue == 1.0f)
        {
            myIntValue = 4;
        }

        Debug.Log("myIntValue translated to: " + myIntValue);
        StartCoroutine(SpawnAway());
    }

    

    IEnumerator SpawnAway()
    {
        Debug.Log("ran coroutine w myIntValue of: " +myIntValue);
        
        for(int i = myIntValue; i > 0; i--)
        {
            Instantiate(spawnObject1, spawnLoc1.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            Debug.Log("myIntValue Spawns Left");
        }
    }

    public void Button1Stage()
    {
        Debug.Log("1 Stage Button Pressed");
    }

    public void Button2Stage()
    {
        Debug.Log("2 Stage Button Pressed");
    }

    public void Button2StageChanged()
    {
        Debug.Log("2 Stage Button Changed");
    }
}

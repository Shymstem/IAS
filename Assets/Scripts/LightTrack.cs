using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrack : MonoBehaviour
{
    public GameObject theObject;
    
    void Update()
    {
        transform.LookAt(theObject.transform);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampFloatData : MonoBehaviour
{
 
    public FloatData playerHealth, maximumHealth;

    public void OnEnable ()
    {
        playerHealth.value = maximumHealth.value;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class TriggerModelExplode : MonoBehaviour
{

    public GameObject obj;

    public VisualEffect effect;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            effect.SendEvent("OnExplode");
            Destroy(obj);
        }
    }
}

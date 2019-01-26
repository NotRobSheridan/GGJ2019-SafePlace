using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuicyCards : MonoBehaviour {

    private void Awake()
    {
        transform.Rotate(0.0f, Random.Range(0.0f, 360.0f), 0.0f);
    }
}

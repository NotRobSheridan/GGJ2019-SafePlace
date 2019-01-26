using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitialiseOwnerCard : MonoBehaviour {

    public Text clue1, clue2, clue3, clue4, clue5, clue6, ownerName, safeCode;


    // Use this for initialization
    private void Awake()
    {
        clue1.text = Random.Range(0, 10000).ToString();
        clue2.text = Random.Range(0, 10000).ToString();
        clue3.text = Random.Range(0, 10000).ToString();
        clue4.text = Random.Range(0, 10000).ToString();
        clue5.text = Random.Range(0, 10000).ToString();
        clue6.text = Random.Range(0, 10000).ToString();
        ownerName.text = "Name: " + Random.Range(0, 10000).ToString();
        safeCode.text = "Code: " + Random.Range(1000, 4000).ToString();

    }
}

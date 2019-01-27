using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitialiseOwnerCard : MonoBehaviour {

    public Text ownerName, safeCode;
    public Text[] clues = new Text[6];

    // Use this for initialization
    private void Awake()
    {
        
    }

    public void FillData(string ownerText, string clueText, string safeCodeText)
    {
        for(int i = 0; i < clues.Length; i++)
        {
            ownerName.text = ownerText;
            safeCode.text = safeCodeText;
            clues[i].text = clueText;

        }
    }
}

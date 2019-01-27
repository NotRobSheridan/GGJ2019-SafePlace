using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitialiseOwnerCard : MonoBehaviour {

    public Text ownerName, safeCode;
    public Text likes;
    public Text dislikes;

    // Use this for initialization
    private void Awake()
    {
        
    }

    public void FillData(string ownerText, string likesText, string dislikesText, string safeCodeText)
    {
            ownerName.text = ownerText;
            safeCode.text = safeCodeText;
            likes.text = "Likes: " + likesText;
            dislikes.text = "Dislikes: " + dislikesText;
    }
}

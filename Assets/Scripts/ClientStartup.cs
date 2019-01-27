using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WhoLivesInThisHouse;


public class ClientStartup : MonoBehaviour {

    public int maxOwners;
    public GameObject cardCanvas;
    public GameObject ownerCard;
    RectTransform lastCardPos;



    private void Awake()
    {
   
        for (int i = 0; i < maxOwners; i++)
        {
            //Data from JSON goes here? 
            //field = newFieldValueFromJason?
            CreateCard();
        }
    }

    void CreateCard()
    {
        GameObject newCard = Instantiate(ownerCard, transform) as GameObject;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WhoLivesInThisHouse;


public class ClientStartup : MonoBehaviour {

    public int maxOwners;
    public GameObject cardCanvas;
    public GameObject ownerCard;

    //GameContext gameContext;

    private void Awake()
    {

        for (int i = 0; i < maxOwners; i++)
        {
            CreateCard();
        }
    }

    void CreateCard()
    {

        GameObject newCard = Instantiate(ownerCard, transform) as GameObject;
        var cardScript = newCard.GetComponent<InitialiseOwnerCard>();
        cardScript.FillData(/*data from game context)*/"Dummy string", "Dummy string", "Dummy string");
    }
}

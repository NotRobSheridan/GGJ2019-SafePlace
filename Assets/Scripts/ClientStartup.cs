using System.Collections.Generic;
using UnityEngine;
using WhoLivesInThisHouse;

public class ClientStartup : MonoBehaviour {

    public int maxOwners;
    public GameObject cardCanvas;
    public GameObject ownerCard;
    private CharacterListApiCaller apiCaller;

    private void Awake()
    {
        apiCaller = new CharacterListApiCaller("http://192.168.1.95:9595");

        List<Character> characters = apiCaller.GetCharacters();

        foreach (Character character in characters)
        {
            Debug.Log(character);
            CreateCard(character.Name, character.LikeTags, character.DislikeTags, character.SafeCode);
        }
    }

    void CreateCard(string charName, List<Tag> likes, List<Tag> dislikes, string safe)
    {
        GameObject newCard = Instantiate(ownerCard, transform) as GameObject;
        var cardScript = newCard.GetComponent<InitialiseOwnerCard>();

        string likesStr = "";
        string dislikesStr = "";

        foreach(Tag like in likes)
        {
            likesStr += like.Name + "\n";
        }

        foreach (Tag dislike in dislikes)
        {
            dislikesStr += dislike.Name + "\n";
            Debug.Log(dislikesStr);
        }

        cardScript.FillData(charName, likesStr, dislikesStr, safe);
    }
}

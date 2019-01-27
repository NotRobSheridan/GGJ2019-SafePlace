RobsBranch
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WhoLivesInThisHouse;

public class HostPlaySceneManager : MonoBehaviour {
    public int maxObjects;
    private GameContext gameContext;
    

    void Start()
    {

        gameContext = GameContext.Instance;
        Debug.Log(gameContext.CurrentRoom.Items);

        foreach(Item item in gameContext.CurrentRoom.Items)
        {
            InstantiateItem(item.Name, item.UiBinding);
            Debug.Log(item.Name);
            Debug.Log(item.Name);
        }

    }

    void InstantiateItem(string itemName, string spawnLocation)
    {
        Transform target = GameObject.FindWithTag(spawnLocation).transform;
        GameObject obj = (GameObject)Instantiate(Resources.Load(itemName), target.transform);
    }


}

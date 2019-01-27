using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WhoLivesInThisHouse;

public class HostPlaySceneManager : MonoBehaviour {
    public int maxObjects;
    public Transform[] interactables = new Transform[8];
    private GameContext gameContext;
    

    void OnAwake()
    {

        gameContext = GameContext.Instance;

        foreach(Item item in gameContext.CurrentRoom.Items)
        {
            InstantiateItem(item.Name, item.UiBinding);
            Debug.Log(item.Name);
            Debug.Log(item.Name);
        }

    }

    void InstantiateItem(string itemName, string spawnLocation)
    {
        Transform target = GameObject.FindWithTag("SpawnLocation").transform;
        GameObject obj = (GameObject)Instantiate(Resources.Load(itemName), target.transform);
    }


}

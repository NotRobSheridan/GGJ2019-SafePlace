//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class HostPlaySceneManager : MonoBehaviour {
//    public int maxObjects;
//    public List<GameObject> interactablePositions = new List<GameObject>();

//    void OnAwake()
//    {
//        for(int i = 0; i < maxObjects; i++)
//        {
//            InstantiateInteractable(incomingData.items[i]); //Iterate through objects to instantiate from deserialized JSON until we have enough objects in the scene
//        }
//    }

//    void InstantiateInteractable(string interactablename)
//    {
//        int spawnId = Random.Range(0, interactablePositions.Count);
//        GameObject obj = (GameObject)Instantiate(Resources.Load(interactablename), interactablePositions[spawnId].transform);
//    }

//    }
//
//}

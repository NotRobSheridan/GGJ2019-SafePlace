using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WhoLivesInThisHouse;

public class NetworkController : MonoBehaviour
{
    private GameContext gameContext;
    JsonFileLoader jsonFileLoader = new JsonFileLoader();

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting game server");
        gameContext = GameContext.Instance;
        //Debug.Log(gameContext.ServerUrl);


        DontDestroyOnLoad(this.gameObject);

        string json = jsonFileLoader.LoadJsonFile("items");

            /*@"[{
              'name': 'Test1',
              'tags': [
                'tag1',
                'tag2'
              ]
            },
            {
              'name': 'Test2',
              'tags': [
                'tag3',
                'tag4'
              ]
            }]";*/

        gameContext.Init(json);
        gameContext.NewGame(6);
        Debug.Log(gameContext.Characters[0]);
        Debug.Log(gameContext.Characters[1]);
        Debug.Log(gameContext.Characters[2]);
        Debug.Log(gameContext.Characters[3]);
        Debug.Log(gameContext.Characters[4]);
        Debug.Log(gameContext.Characters[5]);
    }

    /// <summary>
    /// This function is called when the MonoBehaviour will be destroyed.
    /// </summary>
    void OnDestroy()
    {
        gameContext.Stop();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WhoLivesInThisHouse;

public class NetworkController : MonoBehaviour
{
    private GameContext gameContext;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting game server");
        gameContext = GameContext.Instance;

        DontDestroyOnLoad(this.gameObject);

        string json = @"[{
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
            }]";

        gameContext.Init(json);
        gameContext.NewGame(6);
        Debug.Log(gameContext.Characters[0]);
        Debug.Log(gameContext.Characters[1]);
        Debug.Log(gameContext.Characters[2]);
        Debug.Log(gameContext.Characters[3]);
        Debug.Log(gameContext.Characters[4]);
        Debug.Log(gameContext.Characters[5]);
        Debug.Log(gameContext.Characters[6]);
    }

    /// <summary>
    /// This function is called when the MonoBehaviour will be destroyed.
    /// </summary>
    void OnDestroy()
    {
        gameContext.Stop();
    }
}
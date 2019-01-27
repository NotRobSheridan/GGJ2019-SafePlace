using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClientStartScreenScript : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void OnButtonPressed()
    {
        SceneManager.LoadScene("ClientPlayScene");
    }
}

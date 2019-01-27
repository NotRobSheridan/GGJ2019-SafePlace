using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonFileLoader : MonoBehaviour {

    public string LoadJsonFile(string fileName)
    {
        TextAsset textFile = Resources.Load<TextAsset>(fileName.Replace(".json.txt", ".json"));
        return textFile.text;
    }

}

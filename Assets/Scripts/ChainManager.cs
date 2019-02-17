using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ChainManager : MonoBehaviour
{
    public List<GameHandler> gameHandlers;

    // Start is called before the first frame update
    void Start()
    {
        gameHandlers[0].Handle(null);
        for (int i = 1; i < gameHandlers.Count; i++) 
        {
            gameHandlers[i - 1].SetNext(gameHandlers[i]);
        }
    }
}

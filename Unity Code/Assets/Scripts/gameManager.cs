using UnityEngine;
using System.Collections;

// Game States
public enum GameState {S1,S2,S3,S4}

public delegate void OnStateChangeHandler();

public class gameManager : Object
{
    protected gameManager() { }
    private static gameManager instance = null;
    public event OnStateChangeHandler OnStateChange;
    public GameState gameState { get; private set; }

    public static gameManager Instance
    {
        get
        {
            if (gameManager.instance == null)
            {
                gameManager.instance = new gameManager();
                if (gameManager.instance != null)
                {
                    DontDestroyOnLoad(gameManager.instance);
                }
                }
            return gameManager.instance;
        }

    }

    public void SetGameState(GameState state)
    {
        this.gameState = state;
        OnStateChange();
    }

    public void OnApplicationQuit()
    {
        gameManager.instance = null;
    }

}
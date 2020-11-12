using UnityEngine;
using System.Collections;

public class part1 : MonoBehaviour
{

    gameManager GM;

    void Awake()
    {
        GM = gameManager.Instance;
        GM.OnStateChange += HandleOnStateChange;
        Debug.Log("Current game state when Awakes: " + GM.gameState);
    }

    void Start()
    {
        Debug.Log("Current game state when Starts: " + GM.gameState);
        GM.SetGameState(GameState.S1);
    }

    public void HandleOnStateChange()
    {
        Debug.Log("Handling state change to: " + GM.gameState);
        Invoke("LoadS1", 3f);
    }

    public void LoadS1()
    {
        Debug.Log("Loaded S1");
        Debug.Log("Start game tied to chair");
        //Invoke("LoadS2", 3f);
        //or
        Invoke("LoadS3",3f);
        GM.SetGameState(GameState.S3);

    }

    public void LoadS2()
    {
        Debug.Log("Loaded S2");
        Debug.Log("Do nothing.");
        Invoke("LoadS3",3f);
        GM.SetGameState(GameState.S3);

        //or Invoke("LoadS2", 3f);
    }


    public void LoadS3()
    {
        Debug.Log("Loaded S3");
        Debug.Log("Untied hands.");
        Invoke("LoadS4", 3f);
        GM.SetGameState(GameState.S4);

        //or Invoke("LoadS5", 3f);
        //or Invoke("LoadS6", 3f);
        //or Invoke("LoadS7", 3f);

    }

    public void LoadS4()
    {
        Debug.Log("Loaded S4");
        Debug.Log("Wardrobe interactions.");

    }


    public void LoadS5()
    {
        Debug.Log("Loaded S5");
        Debug.Log("Door interaction.");
    }


    public void LoadS6()
    {
        Debug.Log("Loaded S6");
        Debug.Log("Water interactions.");
    }

    public void LoadS7()
    {
        Debug.Log("Loaded S7");
        Debug.Log("Walk around");
    }







}
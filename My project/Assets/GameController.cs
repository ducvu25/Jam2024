using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    Vector3[] savePoints;
    
    GameObject goPlayerA, goPlayerB;
    public static GameController instance;

    bool pause;
    bool audio;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {    
        pause = false;
        audio = false;
        SetAudio();

        savePoints[0] = goPlayerA.transform.position;
        savePoints[1] = goPlayerB.transform.position;
    }
    void InitPlayer(bool value)
    {
        if (value)
        {
            goPlayerA.transform.position = savePoints[0];
        }
        else
        {
            goPlayerB.transform.position = savePoints[1];
        }
    }

    // Update is called once per frame
/*    void Update()
    {
        
    }*/
    public bool Pause
    {
        get { return pause; }
    }
    public void PauseGame()
    {
        pause = !pause;
        UIController.instance.PauseGame(pause);
    }
    
    public void NewGame()
    {

    }
    public void SetAudio() { 
        audio = !audio;
        UIController.instance.SetAudio(audio);
    }
    public void Menu()
    {
        SceneManager.LoadScene(DataGame.GetNameScene(MAP_GAME.menu));
    }
    public void Exit()
    {
        Application.Quit();
    }
}

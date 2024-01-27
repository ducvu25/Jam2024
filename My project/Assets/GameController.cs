using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.GraphView.GraphView;

public class GameController : MonoBehaviour
{
    List<Vector3> savePoints;
    
    [SerializeField] GameObject goPlayerA, goPlayerB;
    [SerializeField] Vector3 poGround;
    int score;
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
        score = 0;
        SetAudio();

        savePoints = new List<Vector3>();
        savePoints.Add(goPlayerA.transform.position);
        savePoints.Add(goPlayerB.transform.position);
    }

    public void InitPlayer(bool value)
    {
        StartCoroutine(InitPlayer(value, 0.5f));
    }
    IEnumerator InitPlayer(bool value, float t)
    {
        yield return new WaitForSeconds(t);
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
        SceneManager.LoadScene(DataGame.GetNameScene(MAP_GAME.lv1));
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
    public void UpdateScore(bool value)
    {
        int x = (int)((value ? goPlayerA.transform.position.y : goPlayerB.transform.position.y) - poGround.y);
        if(x > score)
        {
            score = x;
            UIController.instance.SetScore(score);
        }
    }
}

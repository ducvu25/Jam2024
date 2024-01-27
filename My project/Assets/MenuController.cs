using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Play()
    {
        SceneManager.LoadScene(DataGame.GetNameScene(MAP_GAME.lv1));
    }
    public void Setting()
    {

    }
    public void About()
    {

    }
    public void Exit()
    {
        Application.Quit();
    }
}

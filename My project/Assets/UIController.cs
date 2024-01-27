using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject goPauseMenu;
    [SerializeField] TextMeshProUGUI txtAudio;

    public static UIController instance;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
/*
    // Update is called once per frame
    void Update()
    {
        
    }*/
    public void PauseGame(bool pause)
    {
        if (pause)
        {
            goPauseMenu.transform.GetComponent<Animator>().SetTrigger("On");
        }
        else
        {
            goPauseMenu.transform.GetComponent<Animator>().SetTrigger("Off");
            //StartCoroutine(SetPause(false, 0.5f));
        }
    }
    /*IEnumerator SetPause(bool value, float timeDelay)
    {
        yield return new WaitForSeconds(timeDelay);
        goPauseMenu.SetActive(value);
    }*/
    
    public void SetAudio(bool value)
    {
        txtAudio.text = "Âm nhạc: " + (value ? "Bật" : "Tắt");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectController : MonoBehaviour
{
    [SerializeField] GameObject[] goInformations;

    // Start is called before the first frame update
    void Start()
    {

        SelectPlayer(true);
    }
    void SelectPlayer(bool playerA)
    {
        if (playerA)
        {
            goInformations[0].SetActive(true);
            goInformations[1].SetActive(false);
        }
        else
        {
            goInformations[1].SetActive(true);
        }
        
    }
}

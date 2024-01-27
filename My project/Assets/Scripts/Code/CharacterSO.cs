using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewInfomationSO", menuName = "Custom/Create CharacterSO")]
public class CharacterSO : ScriptableObject
{
    [SerializeField] Sprite hub;
    [SerializeField] GameObject character;
    [SerializeField] string name;
    [SerializeField] string infomation;

    public Sprite Hub
    {
        get { return hub; }
    }
    public GameObject Character
    {
        get { return character; }
    }

    public string Name
    {
        get { return name; }
    }

    public string Infomation
    {
        get { return infomation; }
    }

    public InfomationSO InfomationSO()
    {
        return character.transform.GetComponent<InfomationSO>(); 
    }
}

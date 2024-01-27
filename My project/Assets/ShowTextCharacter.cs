using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowTextCharacter : MonoBehaviour
{
    TextMeshProUGUI txtNameCharacter;
    // Start is called before the first frame update
    void Start()
    {
        txtNameCharacter = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
    }
    public void SetName(string name)
    {
        txtNameCharacter.text = name;
    }
    public void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
}

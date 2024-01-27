using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    [SerializeField] List<GameObject> sprites;
    [SerializeField] float delay = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < sprites.Count; i++)
        {
            sprites[i].SetActive(false);    
        }
        StartCoroutine(UpdateLoading(0, sprites.Count));
    }

    IEnumerator UpdateLoading(int i, int n)
    {
        yield return new WaitForSeconds(delay);
        if(i < n)
        {
            int x = (int)Random.Range(0, 3);
            if (x == 0)
            {
                sprites[i].SetActive(true);
            }
            else
            {

            }

            StartCoroutine(UpdateLoading(i + 1, n));
        }
        else
        {
            SceneManager.LoadScene(DataGame.GetNameScene(MAP_GAME.menu));
        }
    }
}

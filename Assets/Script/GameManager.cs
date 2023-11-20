using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject TitleScreen;
    // Start is called before the first frame update
    void Start()
    {
        TitleScreen.SetActive(true);
    }

    // Update is called once per frame

    public void StartGameButton()
    {
        TitleScreen.SetActive(false);
    }
    

}

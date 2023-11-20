using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject UI_BG, Prologue, Prologue2, Prologue3, Introduction, Exit, Title, Bg_1, Play;
    public int health, stamina;
    public TextMeshProUGUI healthText, staminaText;
    // Start is called before the first frame update
    void Start()
    {
        UI_BG.SetActive(true);
    }

    // Update is called once per frame

    public void StartGameButton()
    {
        Play.SetActive(false);
        Bg_1.SetActive(false);
        Title.SetActive(false);
        Exit.SetActive(false);
        Introduction.SetActive(true);
    }
    public void IntroStart()
    {
        Introduction.SetActive(false);
        Prologue.SetActive(true);
    }
    public void PrologueNext()
    {
        Prologue.SetActive(false);
        Prologue2.SetActive(true);
    }
    public void PrologueNext2()
    {
        Prologue2.SetActive(false);
        Prologue3.SetActive(true);
    }
}

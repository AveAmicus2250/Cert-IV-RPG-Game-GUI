using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassManager : MonoBehaviour
{
    public GameObject CharacterClassMenu, StatsMenu;
    public bool showStats = false;


    public void ToggleCharacterClass()
    {
        CharacterClassToggle();
    }
    bool CharacterClassToggle()
    {
        if (showStats)
        {
            showStats = false;
            CharacterClassMenu.SetActive(true);
            StatsMenu.SetActive(false);
            return false;
        }
        else
        {
            showStats = true;
            CharacterClassMenu.SetActive(false);
            StatsMenu.SetActive(true);
            return false;
        }
    }
}
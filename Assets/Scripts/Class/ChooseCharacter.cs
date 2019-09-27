using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCharacter : MonoBehaviour
{
    #region Variables
    [Header("Character Name")]
    public string charName = "Adventurer";
    //name of our character that the user is making
    [Header("Stats")]
    //base stats for player
    public int str = 1;
    public int dex = 1, charisma = 1, con = 1, intel = 1, wis = 1;
    //points in which we use to increase our stats
    public int points = 10;
    public CharacterClass charClass = CharacterClass.Barbarian;
    public string[] selectedClass = new string[8];
    public int selectedIndex = 0;
    #endregion
    void ChooseClass(int className)
    {
        switch (className)
        {
            case 0:
                str = 15;
                dex = 10;
                con = 10;
                wis = 10;
                intel = 10;
                charisma = 5;
                charClass = CharacterClass.Barbarian;
                break;
            case 1:
                str = 15;
                dex = 10;
                con = 10;
                wis = 10;
                intel = 10;
                charisma = 5;
                charClass = CharacterClass.Bard;
                break;
            case 2:
                str = 15;
                dex = 10;
                con = 10;
                wis = 10;
                intel = 10;
                charisma = 5;
                charClass = CharacterClass.Druid;
                break;
            case 3:
                str = 15;
                dex = 10;
                con = 10;
                wis = 10;
                intel = 10;
                charisma = 5;
                charClass = CharacterClass.Monk;
                break;
            case 4:
                str = 15;
                dex = 10;
                con = 10;
                wis = 10;
                intel = 10;
                charisma = 5;
                charClass = CharacterClass.Paladin;
                break;
            case 5:
                str = 15;
                dex = 10;
                con = 10;
                wis = 10;
                intel = 10;
                charisma = 5;
                charClass = CharacterClass.Ranger;
                break;
            case 6:
                str = 15;
                dex = 10;
                con = 10;
                wis = 10;
                intel = 10;
                charisma = 5;
                charClass = CharacterClass.Sorcerer;
                break;
            case 7:
                str = 15;
                dex = 10;
                con = 10;
                wis = 10;
                intel = 10;
                charisma = 5;
                charClass = CharacterClass.Warlock;
                break;
        }
    }
    #region CharacterClass
    public enum CharacterClass
    {
        Barbarian,
        Bard,
        Druid,
        Monk,
        Paladin,
        Ranger,
        Sorcerer,
        Warlock
    }
    #endregion
}

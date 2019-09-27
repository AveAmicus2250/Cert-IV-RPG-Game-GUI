using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterClass : MonoBehaviour
{
    [Header("Stats")]
    //base stats for player
    public Text[] buttonLabel = new Text[8];
    public static int[] stats = new int[6];
    //points in which we use to increase our stats
    public static string[] selectedClass;
    void Start()
    {
        selectedClass = new string[8] { "Barbarian", "Bard", "Druid", "Monk", "Paladin", "Ranger", "Sorcerer", "Warlock" };
        for (int i = 0; i < 8; i++)
        {
            buttonLabel[i].text = selectedClass[i]; 
            buttonLabel[i].transform.parent.name = selectedClass[i];
        }
    }
   
    public static void ChooseClass(int className)
    {
        switch (className)
        {
            case 0:
                stats[0] = 8;
                stats[1] = 6;
                stats[2] = 9;
                stats[3] = 6;
                stats[4] = 0;
                stats[5] = 4;
                break;
            case 1:
                stats[0] = 4;
                stats[1] = 9;
                stats[2] = 6;
                stats[3] = 5;
                stats[4] = 0;
                stats[5] = 9;
                break;
            case 2:
                stats[0] = 3;
                stats[1] = 4;
                stats[2] = 6;
                stats[3] = 8;
                stats[4] = 9;
                stats[5] = 7;
                break;
            case 3:
                stats[0] = 7;
                stats[1] = 8;
                stats[2] = 3;
                stats[3] = 6;
                stats[4] = 5;
                stats[5] = 10;
                break;
            case 4:
                stats[0] = 2;
                stats[1] = 7;
                stats[2] = 5;
                stats[3] = 8;
                stats[4] = 6;
                stats[5] = 7;
                break;
            case 5:
                stats[0] = 6;
                stats[1] = 8;
                stats[2] = 6;
                stats[3] = 7;
                stats[4] = 0;
                stats[5] = 6;
                break;
            case 6:
                stats[0] = 3;
                stats[1] = 8;
                stats[2] = 7;
                stats[3] = 2;
                stats[4] = 5;
                stats[5] = 9;
                break;
            case 7:
                stats[0] = 7;
                stats[1] = 4;
                stats[2] = 7;
                stats[3] = 3;
                stats[4] = 6;
                stats[5] = 4;
                break;
                
        }
    }
    
}

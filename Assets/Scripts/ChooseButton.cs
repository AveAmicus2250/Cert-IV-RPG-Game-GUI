using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseButton : MonoBehaviour {
    public int index;
    public GameManager gm;
    private void Start()
    {
       CharacterClass.ChooseClass(0);
        for (int s = 0; s < CharacterClass.stats.Length; s++)
        {
            gm.stats[s].value = CharacterClass.stats[s];
        }
    }
        
    
    public void Choose()
    {
        for (int i = 0; i < 8; i++)
        {
            if (CharacterClass.selectedClass[index] == this.gameObject.name)
            {
                Debug.Log(this.gameObject.name);

                CharacterClass.ChooseClass(index);
                
                
            }
        }
        for (int s = 0; s < CharacterClass.stats.Length; s++)
        {
            gm.stats[s].value = CharacterClass.stats[s];
        }
        //updateui
        gm.StatButtonUpdate();
    }
}

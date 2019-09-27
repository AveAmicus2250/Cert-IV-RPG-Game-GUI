using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[Serializable]
public class Stat
{
    public string name;
    public int value;
    public int  tempvalue;

    

    public StatUI ui;
    public void Plus()
    {
        // Check if value exceeds limits
        if(tempvalue < GameManager.maxPoints)
        {
            tempvalue++;
            GameManager.maxPoints--;
            UpdateUI();
        }        
    }
    public void Minus()
    {
        if(tempvalue >0 && GameManager.maxPoints < 10)
        {
            tempvalue--;
            GameManager.maxPoints++;
            UpdateUI();
        }
    }

    public void UpdateUI()
    {
        int myVal = value+ tempvalue;
        ui.nameText.text = name.ToString();
        ui.valueText.text = (myVal.ToString());

        
    }
}

public class GameManager : MonoBehaviour
{
    public Stat[] stats;
    public static int maxPoints = 10;

    public Transform statParent;
    public GameObject statPrefab;
    public Text pointsToSpend;
    void Start()
    {
        SpawnStats();
        for (int i = 0; i < stats.Length; i++)
        {
            stats[i].value = CharacterClass.stats[i];
        }
    }
    private void Update()
    {
        pointsToSpend.text = maxPoints.ToString();
    }
    public void StatButtonUpdate()
    {
        foreach (var stat in stats)
        {
            stat.UpdateUI();
        }
    }
    public void SpawnStats()
    {
        foreach (var stat in stats)
        {
            // Spawn a UI element
            GameObject clone = Instantiate(statPrefab, statParent);
            clone.name = stat.name; // Update name of GameObject (for Hierarchy)
            // Set the text
            StatUI ui = clone.GetComponent<StatUI>();
            stat.ui = ui;
            // Call minus in stat when button is pressed
            ui.minusButton.onClick.AddListener(stat.Minus);
            // Call plus in stat when button is pressed
            ui.plusButton.onClick.AddListener(stat.Plus);
            // Update the UI at start
            stat.UpdateUI();
        }
    }
    // Update is called once per frame

}

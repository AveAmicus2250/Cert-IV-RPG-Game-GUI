using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{

    #region Singleton

    public static EquipmentManager instance;

    void Awake()
    {
        instance = this;
    }

    #endregion

    Equipment[] currentEquipment;

    void Start()
    {
       int numSlots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
    }
}

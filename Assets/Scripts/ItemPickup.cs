﻿using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;

    public Color color;

    public override void Interact()
    {
        base.Interact();

        PickUp();

    }

    void PickUp()
    {
        

        Debug.Log("Picking up " + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);

        if (wasPickedUp)
            Destroy(gameObject);
    }
}

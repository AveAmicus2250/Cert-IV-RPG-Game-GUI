using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{

    public Image icon;
    public Button removeButton;

    Item item;

    public void AddItem (Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;

        //Fuck
        //icon.color = item.color;

        icon.enabled = true;
        removeButton.interactable = true;
        Debug.Log("Adding Item");
    }

    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
        Debug.Log("Clearing Slot");
    }

    public void OnRemoveButton()
    {
        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;

        Inventory.instance.Remove(item);
    }

    public void UseItem()
    {
        if(item != null)
        {
            item.Use();
        }
    }
}

using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class inventory : MonoBehaviour
{
    [SerializeField]
    private GameObject inventrySlotUI;
    [SerializeField]
    private int maxSlots = 10;
    [SerializeField]
    private GridLayoutGroup inventoryGroup;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < maxSlots; i++)
        {
            SpawnInventorySlot();
        }
    }

    void SpawnInventorySlot()
    {
        GameObject slot = Instantiate(inventrySlotUI);
        slot.gameObject.transform.SetParent(inventoryGroup.transform, false);
    }

}

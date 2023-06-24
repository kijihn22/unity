using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemGenerator : MonoBehaviour
{
    [SerializeField] itemListEntity itemListEntity;

    public static itemGenerator instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public Item Spawn(Item.Type type)
    {
        // itemListの中からtypeと一致したら同じitemを生成して渡す
        foreach (Item item in itemListEntity.itemList)
        {
            if (item.type == type)
            {
                return new Item(item.type, item.sprite);
            }
        }
        return null;
    }
}

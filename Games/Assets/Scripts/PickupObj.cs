using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    [SerializeField] Item.Type itemType;
    Item item;

    private void Start()
    {
        //  itemTypeに応じてitemを生成する
        item = itemGenerator.instance.Spawn(itemType);
    }

    // クリックしたら消す
    public void OnClickObj()
    {
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);
    }
}

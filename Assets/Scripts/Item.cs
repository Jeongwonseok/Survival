﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item")]
public class Item : ScriptableObject
{

    public string itemName; // 아이템의 이름
    [TextArea]
    public string itemDesc; // 아이템의 설명
    public ItemType itemType; // 아이템의 유형
    public Sprite itemImage; // 아이템의 이미지
    public GameObject itemPrefab; // 아이템의 프리펩

    public GameObject kitPrefab; // 키트 프리펩
    public GameObject kitPreviewPewfab; // 키트 프리뷰 프리펩

    public string weaponType; // 무기유형 

    public enum ItemType
    {
        Equipment,
        Used,
        Ingredient,
        Kit,
        ETC
    }



}

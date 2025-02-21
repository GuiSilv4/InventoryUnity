using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System.Collections.Generic;

public class ItemReference : MonoBehaviour
{  
    public Image Icon;
    public TMP_Text CountText;
    public Item _Item {get; private set;}
    private Image BackGroundIcon;
    public List<Sprite> ItemRarityBackground;
    public void SetValues(Item item){
        _Item = item;
        Icon.sprite = item.Icon;
        Debug.Log("Item Rarity: " + item.ItemRarity );
        UpdateItemRaritySprite(item.ItemRarity);
        UpdateCount(); 
    }

    private void UpdateCount() {
        CountText.text = "x" + _Item.Count.ToString();
    }

    private void UpdateItemRaritySprite(int itemRarity) {
        BackGroundIcon = transform.Find("ItemBackground").GetComponent<Image>();
        switch (itemRarity)
        {   
            case 1:
            Debug.Log("AQUI 1");
                BackGroundIcon.sprite = ItemRarityBackground[0];
                break; 
            case 2:
             Debug.Log("AQUI 2");
                BackGroundIcon.sprite = ItemRarityBackground[1];
                break; 
            case 3:
                BackGroundIcon.sprite = ItemRarityBackground[2];
                break; 
            case 4:
                BackGroundIcon.sprite = ItemRarityBackground[3];
                break; 
            case 5:
                BackGroundIcon.sprite = ItemRarityBackground[4];
                break; 
            case 6:
                BackGroundIcon.sprite = ItemRarityBackground[4];
                break; 
            default:
               BackGroundIcon.sprite = ItemRarityBackground[0];
                break; 
        }
        if (BackGroundIcon != null)
            BackGroundIcon.rectTransform.sizeDelta = new Vector2(80, 80);
    }
}

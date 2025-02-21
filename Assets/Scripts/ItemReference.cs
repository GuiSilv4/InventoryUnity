using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class ItemReference : MonoBehaviour
{  
    public Image Icon;
    public Image BackgroundIcon;
    public TMP_Text CountText;
    public Item _Item {get; private set;}

    public void SetValues(Item item){
        _Item = item;
        Icon.sprite = item.Icon;
        BackgroundIcon.sprite = item.BackgroundRarity;
        UpdateCount(); 
    }

    private void UpdateCount() {
        CountText.text = "x" + _Item.Count.ToString();
    }
}

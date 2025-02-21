using UnityEngine;
using UnityEngine.UI;

public class ItemReference : MonoBehaviour
{  
    public Image Icon;
    public Image BackgroundIcon;
    public Text CountText;
    public Item _Item {get; private set;}

    public void SetValues(Item item){
        _Item = item;
        Icon.sprite = item.Icon;
        UpdateCount(); 
    }

    private void UpdateCount() {
    }
}

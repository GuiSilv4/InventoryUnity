using UnityEngine;
using System.Linq;

[CreateAssetMenu(fileName = "NewItem", menuName = "Scriptable Objects/Create Item", order = 1)]
public class Item : ScriptableObject {
    public Sprite Icon;
    public Sprite BackgroundRarity;
    public string Name;
    public string Description;

    public int ID {get; private set;}
    
    public int Count  { get {
            return 
                FindFirstObjectByType<FakeInventory>()._Inventory.FindAll(
                    x => x.ID == this.ID).Count;
        }
    }

    private void OnEnable()
    {
        ID = this.GetInstanceID();
    }
}


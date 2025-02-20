using UnityEngine;
using System.Linq;
using System.Collections.Generic;
public class FakeInventory : MonoBehaviour
{
    [SerializeField]
    Item[] arrayInventory;

    public List<Item> _Inventory {get; private set;}

    private void Awake() {
        _Inventory = new List<Item>();
        _Inventory = arrayInventory.OrderBy(i=> i.Name).ToList();
    }

    public void AddItem(Item item) {
        if(item != null) {
            _Inventory.Add(item);
        }
    }

    public void RemoveItem(Item item) {
        if (item != null ) {
            _Inventory.Remove(item);
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    private List<Item> _inventory;
    public ItemReference _element;
    void Start()
    {
          _inventory = new List<Item>();  
          _inventory = FindFirstObjectByType<FakeInventory>()._Inventory;
          InstantiateElements();
    }

    private void InstantiateElements() {
        for (int i = 0; i < _inventory.Count ; i++)
        {
            if(IsRepeated(i))
                continue;
            (Instantiate(_element, transform) as ItemReference).SetValues(_inventory[i]);
        }
    }

    bool IsRepeated (int i) {
        if(i == 0)
            return false;
        
        return _inventory[i].ID == _inventory[i - 1].ID;
    }
}


using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Scriptable Objects/Create Item", order = 1)]
public class Item : ScriptableObject {
    public Sprite Icon;
    public string Name;
    public string Description;

    public int ID {get; private set;}

    private void OnEnable()
    {
        ID = this.GetInstanceID();
    }
}


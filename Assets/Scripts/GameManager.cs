using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject inventoryUI; // Referência ao Canvas do Inventário

    void Update()
    {
        // Verifica se a tecla "I" foi pressionada
        if (Input.GetKeyDown(KeyCode.I))
        {
            // Alterna a visibilidade do inventário
            inventoryUI.SetActive(!inventoryUI.activeSelf);
        }
    }
}

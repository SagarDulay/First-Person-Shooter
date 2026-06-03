using TMPro;
using UnityEngine;

public class UiAimFeedback : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI interactionText;
    [SerializeField] private PlayerInteractorModule interactorModule;

    private void Start()
    {
        interactorModule.OnNewInteractionFound += DisplayInteractionText;
    }

    public void DisplayInteractionText(GameObject interaction)
    {
        if(interaction == null)
        {
            HideInteractionText();
        }
        else
        {
            interactionText.gameObject.SetActive(true);
            interactionText.text = " PRESS RMB TO INTERACT W/ " + interaction.name;
        }
    }

    public void HideInteractionText()
    {
        interactionText.gameObject.SetActive(false);
    }
}

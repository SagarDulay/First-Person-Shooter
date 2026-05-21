using TMPro;
using UnityEngine;

public class PlayerInteractorModule : MonoBehaviour
{
    [SerializeField] private Transform interactionRayOrigin;
    [SerializeField] private float interactionRange;
    [SerializeField] private LayerMask interactableLayers;
    [SerializeField] private TextMeshProUGUI interactNotiText;

    private GameObject selectedObject;
    public Interactable pickedUpObject;
    void Update()
    {
        Ray ray = new Ray(interactionRayOrigin.position, interactionRayOrigin.forward * interactionRange);

        RaycastHit hitInfo;
        if( Physics.Raycast(ray, out hitInfo, interactionRange, interactableLayers))
        {
            selectedObject = hitInfo.collider.gameObject;
            interactNotiText.gameObject.SetActive(true);
        }
        else
        {
            selectedObject = null; 
            interactNotiText.gameObject.SetActive(false);
        }
    }

    public void InteractWith()
    {
        if(selectedObject)
        {
            Interactable interaction = selectedObject.GetComponent<Interactable>();
            interaction.OnStartInteraction.Invoke();

            if(interaction is InteractablePickup)
            {
                pickedUpObject = interaction;
                pickedUpObject.transform.SetParent(interactionRayOrigin);
            }
        }
    }

    public void StopInteractWith()
    {
        if(pickedUpObject)
        {
            pickedUpObject?.transform.SetParent(null);
            pickedUpObject.OnStopInteraction.Invoke();
            pickedUpObject=null;
        }
    }
}

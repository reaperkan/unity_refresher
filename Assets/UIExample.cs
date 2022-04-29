using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class UIExample : MonoBehaviour
{

    public Button button;
    
    void Start()
    {
        button.onClick.AddListener(HandleClick);

        // Different UIS and their main listeners
        // Button       -   onClick
        // Dropdown     -   onValueChanged
        // InputField   -   onEndEdit, onValidateInput, onValueChanged
        // Scrollbar    -   onValueChanged
        // ScrollRect   -   onValueChanged
        // Slider       -   onValueChanged
        // Toggle       -   onValueChanged

        // Adding Mouse Listeners
        EventTrigger eventTrigger = GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((data) => {onPointerDownDelegate((PointerEventData) data); });
        eventTrigger.triggers.Add(entry);

        // Available event ids are
        // PointerEnter
        // PointerExit
        // PointerDown
        // PointerUp
        // PointerClick
        // Drag
        // Drop
        // Scroll
        // UpdateSelected
        // Select
        // Deselect
        // Move
        // InitializePotentialDrag
        // BeginDrag
        // EndDrag
        // Submit
        // Cancel
    }

    void onPointerDownDelegate(PointerEventData data){

    }

    void HandleClick(){

    }
}

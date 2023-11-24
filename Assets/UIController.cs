using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements; //this

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update

    public Button ButtonExample;
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        ButtonExample = root.Q<Button>("Button");
        ButtonExample.clicked += ButtonExampleClicked;
    }

    void ButtonExampleClicked()
    {
        print("Mumma De Mia!");
    }

}

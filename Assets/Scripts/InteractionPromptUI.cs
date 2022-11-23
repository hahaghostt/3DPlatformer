using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPromptUI : MonoBehaviour
{
    private Camera _mainCam;
    [SerializeField] private GameObject _uiPanel;
  

    private void Start()
    {
        _mainCam = Camera.main;
        _uiPanel.SetActive(false); 
    }

    private void LateUpdate()
    {
        var rotation = _mainCam.transform.rotation;
        transform.LookAt(transform.position + rotation * Vector3.forward, 
            rotation * Vector3.up);
    }
    public bool IsDisplayed = false; 

    public void Setup(string promptText)
    {
        _uiPanel.SetActive(true);
        IsDisplayed = true; 
    }
    public void Close()
    {

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    [SerializeField] private InputActionReference _gripReference;
    
    [SerializeField] private InputActionReference _triggerReference;
    
    [SerializeField] private Animator _handAnimator;

    // Update is called once per frame
    void Update()
    {
        float gripValue = _gripReference.action.ReadValue<float>();
        _handAnimator.SetFloat("Grip", gripValue);
        
        float triggerValue = _triggerReference.action.ReadValue<float>();
        _handAnimator.SetFloat("Trigger", triggerValue);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FixedXRGrabInteractable : XRGrabInteractable
{

   [SerializeField] private Transform _leftHandAttachTransform;
   [SerializeField] private Transform _rightHandAttachTransform;
   protected override void OnSelectEntered(SelectEnterEventArgs args)
   {

      if (args.interactorObject.transform.CompareTag("LeftHand"))
      {
         attachTransform = _leftHandAttachTransform;
      }

      if (args.interactorObject.transform.CompareTag("RightHand"))
      {
         attachTransform = _rightHandAttachTransform;
      }
      base.OnSelectEntered(args);
   }
}

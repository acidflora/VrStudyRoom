using AosSdk.Core.Interaction;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Player.Pointer;
using AosSdk.Core.Utils;
using UnityEngine;

namespace AosSdk.Examples
{

    public class GrabbableObject : BaseObject, IGrabbable
    {
        [field: SerializeField] public GrabType GrabType { get; set; }

        [field: SerializeField] public Transform GrabAnchor { get; set; }
        [SerializeField] private Transform _ugrabPos;

        public bool IsGrabbable { get; set; } = true;
        public bool IsGrabbed { get; set; }
        private bool _hand;


        public void OnGrabbed(InteractHand interactHand)
        {
            if (interactHand == InteractHand.Right)
                _hand = true;
            else 
                _hand = false;
            //_zoomController.CanZoom = false;
            GetComponent<Collider>().isTrigger = false;
            GetComponent<Rigidbody>().isKinematic = false;
            if (outlineObjects != null)
                foreach (var obj in outlineObjects)
                {
                    obj.OutlineWidth = 0;
                }
            if (helperPos != null)
                canvasObjectHelper.HidetextHelper();
        }

        public void OnUnGrabbed(InteractHand interactHand)
        {
            //_zoomController.CanZoom = true;
            GetComponent<Rigidbody>().isKinematic = true;
            transform.position = _ugrabPos.position;
            transform.rotation = _ugrabPos.rotation;
            GetComponent<Collider>().isTrigger = true;
        }
        private void OnTriggerEnter(Collider other)
        {
            if(other.TryGetComponent(out ViveStation viveStation))
            {
                HandRendererEnabler enabler = FindObjectOfType<HandRendererEnabler>();
                enabler.EnablaHands(_hand);
                viveStation.EnableViveBox();
                Destroy(gameObject);
            }
        }
    }
}
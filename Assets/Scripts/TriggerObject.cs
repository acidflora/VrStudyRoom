using System.Collections.Generic;
using System.Linq;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

namespace AosSdk.CommonBehaviours
{
    [RequireComponent(typeof(Collider))]
    public class TriggerObject : AosObjectBase
    {

        private Collider _thisCollider;

        public UnityAction PlayerEnterTriggerEvent;

        private void Awake()
        {
            _thisCollider = GetComponent<Collider>();

            if (_thisCollider.isTrigger)
            {
                return;
            }

            _thisCollider.isTrigger = true;
        }

        private void OnTriggerEnter(Collider col)
        {
            var aosObject = col.GetComponentInParent<AosObjectBase>();
            if (!aosObject)
            {
                return;
            }

            PlayerEnterTriggerEvent?.Invoke();
            _thisCollider.enabled = false;
        }

        private void OnTriggerExit(Collider col)
        {

        }
    }
}
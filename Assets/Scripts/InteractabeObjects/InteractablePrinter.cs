using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractablePrinter : InteractableObject
{
    [SerializeField] private GameObject _cap;
    [SerializeField] private GameObject _cartridge;
    [SerializeField] private GameObject _repairButton;
    public override void StartAction()
    {
        StartCoroutine(OpenCap());

    }
    private IEnumerator OpenCap()
    {
        _repairButton.SetActive(false);
        int x = 0;
        while (x <=45)
        {
            _cap.transform.localRotation = Quaternion.Euler(-x, 0, 0);
            x++;
            yield return new WaitForSeconds(0.01f);
        }
        int z = 0;
        while (z < 18)
        {
            _cartridge.transform.localPosition += new Vector3(0, 0,0.005f);
            yield return new WaitForSeconds(0.04f);
            z++;
        }
        _cartridge.SetActive(false);
        yield return new WaitForSeconds(0.8f);
        _cartridge.SetActive(true);
        while (z > 0)
        {
            _cartridge.transform.localPosition -= new Vector3(0, 0, 0.005f);
            yield return new WaitForSeconds(0.04f);
            z--;
        }
        while (x >= 0)
        {
            _cap.transform.localRotation = Quaternion.Euler(-x, 0, 0);
            x--;
            yield return new WaitForSeconds(0.01f);
        }

    }
}

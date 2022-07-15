using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrelkaRotator : MonoBehaviour
{
    [SerializeField] private GameObject _strelka;

    public void RotateStrelka(bool value)
    {
        StartCoroutine(Rotate(value));
    }
    public void ResetStrelka()
    {
        var temp = _strelka.transform.rotation.eulerAngles;
        temp.y = -51;
        _strelka.transform.localRotation = Quaternion.Euler(temp);
    }
    private IEnumerator Rotate(bool value)
    {
        if(value)
        {
            float y = -51;
            while(y<=15)
            {
                var temp = _strelka.transform.rotation.eulerAngles;
                temp.y = y;
                y += 0.6f;
                _strelka.transform.localRotation = Quaternion.Euler(temp);
                yield return new WaitForSeconds(0.005f);
            }
        }
        else
        {
            float y = -51;
            while (y >= -57)
            {
                var temp = _strelka.transform.rotation.eulerAngles;
                temp.y = y;
                y -= 0.1f;
                _strelka.transform.localRotation = Quaternion.Euler(temp);
                yield return new WaitForSeconds(0.03f);
            }
        }

    }

    }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    [SerializeField] private bool _in;

    public void OpenDoor()
    {
        StartCoroutine(OpenDoorCo());
    }
    private IEnumerator OpenDoorCo()
    {
        int y = 0;
        while (y <= 90)
        {
            if (!_in)
                transform.localEulerAngles += new Vector3(0, -1, 0);
            else
                transform.localEulerAngles += new Vector3(0, 1, 0);
            yield return new WaitForSeconds(0.01f);
            y++;
        }
    }
}

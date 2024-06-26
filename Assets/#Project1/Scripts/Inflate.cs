using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inflate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out InflateItem inflateItem))
        {
            inflateItem.Inflate();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out InflateItem inflateItem))
        {
            inflateItem.Deflate();
        }
    }
}

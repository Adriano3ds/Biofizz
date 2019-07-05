using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRotation : MonoBehaviour
{
    RectTransform body;
    // Start is called before the first frame update
    void Start()
    {
        body = (RectTransform) GetComponentInParent(typeof(RectTransform));
        StartCoroutine(DoCheck());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DoCheck()
    {
        for (;;)
        {
            Vector3 rot = body.rotation.eulerAngles;
            rot.z += 0.1f;
            body.rotation = Quaternion.Euler(rot);
            yield return new WaitForSeconds(.1f);
        }
    }
}

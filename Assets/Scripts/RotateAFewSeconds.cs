using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Just a quick rotation during seconds example based of here: https://answers.unity.com/questions/786503/rotate-gameobject-using-coroutine.html
public class RotateAFewSeconds : GameHandler
{
    [SerializeField]
    float rotationSpeed = 10.0f;
    [SerializeField]
    float rotationDuration = 3.0f;
    private bool rotating;

    void Update()
    {
        if (rotating)
        {
            transform.Rotate(Vector3.forward * rotationSpeed*Time.deltaTime);
        }
    }
    IEnumerator StartRotating()
    {
        rotating = true;
        yield return new WaitForSeconds(rotationDuration);
        Debug.Log("The object has finished rotating its position");
        rotating = false;
        base.Handle(null);
    }
    public override object Handle(object request)
    {
        StartCoroutine(StartRotating());
        return null;
    }
}

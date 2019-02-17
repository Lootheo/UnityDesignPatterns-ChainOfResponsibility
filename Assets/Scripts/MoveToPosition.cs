using UnityEngine;


public class MoveToPosition : GameHandler
{
    public bool moveToPosition = false;
    [SerializeField]
    Vector2 positionToMove;
    
    void Update()
    {
        if (moveToPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, positionToMove, Time.deltaTime * 3);
            if (Vector2.Distance(transform.position, positionToMove) == 0)
            {
                FinishedMoving();
            }
        }
    }

    void FinishedMoving()
    {
        Debug.Log("The object reached its position");
        moveToPosition = false;
        base.Handle(null);
    }

    public override object Handle(object request)
    {
        moveToPosition = true;
        return null;
    }
}

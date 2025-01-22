using UnityEngine;

public class PlattformBewegen : MonoBehaviour
{
    public Transform platform;
    public Transform startPoint;
    public Transform endPoint;

    [SerializeField] float speed;
    [SerializeField] int direction;

    private void Update()
    {
        Vector2 target = currentMovementTarget();

        platform.position = Vector2.Lerp(platform.position, target, speed * Time.deltaTime);

        float distance = (target - (Vector2)platform.position).magnitude;

        if (distance <= 0.1f)
        {
            direction *= -1;
        }
    }

    Vector2 currentMovementTarget()
    {
        if (direction == 1)
        {
            return startPoint.position;
        } 
        else
        {
            return endPoint.position;
        }
    }

}

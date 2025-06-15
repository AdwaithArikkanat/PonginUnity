using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringColl : MonoBehaviour
{
    public EventTrigger.TriggerEvent score;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        BallBehaviour ball = collision.gameObject.GetComponent<BallBehaviour>();
        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            score.Invoke(eventData);
        }


    }
}

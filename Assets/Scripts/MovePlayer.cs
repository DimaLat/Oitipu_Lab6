
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private float speed = 10f;

    void OnMouseDrag()
    {
        if (!Player.lose) { 
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (player.position.x < -1)
                player.position = new Vector3(player.position.x + 10f, player.position.y, player.position.z);
            else if (player.position.x > 5)
                player.position = new Vector3(player.position.x - 10f, player.position.y, player.position.z);

            player.position = Vector2.MoveTowards(player.position, 
                new Vector2(mousePos.x, player.position.y),
                speed * Time.deltaTime);
    }
    }

}

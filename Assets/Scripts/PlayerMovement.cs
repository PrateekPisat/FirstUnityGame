using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody player_rb;
    // We edit this value in the propery box in Unity's UI.
    private float player_force_forward=10f;
    // Start is called before the first frame update
    void Start()
    {
      player_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      // Player Movement
      float moveHorizontal = Input.GetAxis("Horizontal") * 10;
      // Work on this when you want to get into jumping
      // float moveVertical = Input.GetAxis("Vertical") * 10;
      Vector3 movement_vector = new Vector3(moveHorizontal, 0, player_force_forward);
      player_rb.AddForce(movement_vector);
    }

    void Update()
    {

    }
}

using UnityEngine;
using UnityEngine.Events;
public class BallController : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager;
    private bool isBallLaunched;

    private Rigidbody ballRB;

    void Start()
    {
        ballRB = GetComponent<Rigidbody>();

        inputManager.OnSpacePressed.AddListener(LaunchBall);

    }

    // Update is called once per frame
    private void LaunchBall()
    {
        if (isBallLaunched) return;
        isBallLaunched = true;
        ballRB.AddForce(transform.forward * force*10, ForceMode.Impulse);
    }
}

using UnityEngine;

public class MoveForward : MonoBehaviour {

    [SerializeField]
    private float speed = .1f;

    private void Update() {
        transform.Translate(transform.forward * speed);
    }

}
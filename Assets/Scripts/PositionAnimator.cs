using UnityEngine;
using System.Collections;

public class PositionAnimator : MonoBehaviour {

    public Vector3 startPosition;
    public Vector3 endPosition;

    public float duration;
    private float startTime;
    private bool animating = false;

    // Update is called once per frame
    void Update() {

        if (duration != 0) { 

            if (Input.GetKeyDown(KeyCode.Space) && !animating) {

                startTime = Time.time;
                animating = true;
            }

            if (animating) {

                transform.position = Vector3.Lerp(startPosition, endPosition, (Time.time - startTime) / duration);

                if (Time.time - startTime > duration) {
                    animating = false;
                }
            }
        }
	}
}

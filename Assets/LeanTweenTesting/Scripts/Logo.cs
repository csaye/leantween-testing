using UnityEngine;

namespace LeanTweenTesting
{
    public class Logo : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) LeanTween.move(gameObject, transform.position + Vector3.one, 1);
        }
    }
}

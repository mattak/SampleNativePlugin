using UnityEngine;
using UnityEngine.UI;

namespace Sample
{
    public class ButtonCheck : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(() => Checker.Check());
        }
    }
}
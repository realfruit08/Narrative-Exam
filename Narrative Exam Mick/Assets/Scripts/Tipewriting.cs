using System.Collections;
using UnityEngine;
using TMPro;
public class Tipewriting : MonoBehaviour
{
    TMP_Text _tmpProText;
    string writer;
    [SerializeField] float timeBtwChars = 0.05f;
    void Start()
    {
        _tmpProText = GetComponent<TMP_Text>();
        if (_tmpProText != null)
        { writer = _tmpProText.text;
            _tmpProText.text = "";
            StartCoroutine(TypeWriter());
        }
    }
    IEnumerator TypeWriter()
    {
        foreach (char c in writer)
        { _tmpProText.text += c;
            yield return new WaitForSeconds(timeBtwChars);
        }
    }
}
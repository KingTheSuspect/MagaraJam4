using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerPoster : MonoBehaviour
{
    public int posterreal;
  //  private Posterid poster;
    [SerializeField] TMPro.TMP_Text dialogueText;

    private void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        dialogueText.color = new Color(dialogueText.color.r, dialogueText.color.g, dialogueText.color.b, 1f);
        if (collision.gameObject.layer == LayerMask.NameToLayer("Posters") && collision.gameObject.GetComponent<Posterid>().posternumber == posterreal)
        {
            Debug.Log("PosterNumber" + collision.gameObject.GetComponent<Posterid>().posternumber);
            Debug.Log("PosterReal" + posterreal);
            dialogueText.text = collision.gameObject.GetComponent<PosterController>().GetText();
            dialogueText.transform.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Posters"))
        {
            StartCoroutine(TextFadeOut());
        }
    }
    IEnumerator TextFadeOut()
    {
        while (dialogueText.color.a > 0)
        {
            Color tempColor = dialogueText.color;
            dialogueText.color = new Color(tempColor.r, tempColor.g, tempColor.b, tempColor.a - .1f);
            yield return new WaitForSeconds(.05f);
        }
        dialogueText.transform.gameObject.SetActive(false);

    }
}

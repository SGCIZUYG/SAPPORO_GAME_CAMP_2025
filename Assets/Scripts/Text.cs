using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class Text : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData e)
    {
        TextMeshProUGUI text = GetComponent<TextMeshProUGUI>();
        Vector3 pos = Input.mousePosition;
        Camera camera = canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : canvas.worldCamera;
        int index = TMP_TextUtilities.FindIntersectingLink(text, pos, camera);

        if (index == -1) return;

        // ƒŠƒ“ƒN‚ğæ“¾
        TMP_LinkInfo linkInfo = text.textInfo.linkInfo[index];
        string url = linkInfo.GetLinkID();

        // ƒŠƒ“ƒNæ‚ğ•\¦
        Application.OpenURL(url);
    }
}

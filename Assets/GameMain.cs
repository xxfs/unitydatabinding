using FBinging.Manager;
using FBinging.Views;
using UnityEngine;

public class GameMain : MonoBehaviour
{
    public void Awake()
    {
        ViewManager.Instance.ReplaceView(typeof(Welcome));
    }

    private void OnDestroy()
    {

    }
}

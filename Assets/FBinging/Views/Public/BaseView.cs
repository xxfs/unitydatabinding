using FairyGUI;
using UnityEngine;

namespace FBinging.Public
{
    public class BaseView
    {
        public BaseView(string pack = null, string scene = null, bool isView = false)
        {
            UIPackage.AddPackage(pack);
            var view = FairyGUI.UIPackage.CreateObject(pack, scene);
            GRoot.inst.AddChild(view);
        }

        public void databinding(params object[] pars)
        {
            Debug.Log("databinding");// + pars[0]
        }

        public void OnDestroy()
        {

        }
    }
}
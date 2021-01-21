using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;
using System;

namespace FBinging.Manager
{
    public class ViewManager
    {
        private static ViewManager instance;
        public static ViewManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ViewManager();
                }
                return instance;
            }
        }

        public void AddUIPackage(string[] names)
        {
            foreach (var packname in names)
            {
                UIPackage.AddPackage(packname);
            }
        }

        public void InitPakage()
        {

        }

        public void ReplaceView(Type viewClass, params object[] args)
        {
            var viewPanel = viewClass.Assembly.CreateInstance(viewClass.FullName);
            if (args.Length > 0)
                viewClass.GetMethod("databinding").Invoke(viewPanel, args);
            else
                viewClass.GetMethod("databinding").Invoke(viewPanel, new object[] { null });
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SimpleFramework
{
    public abstract class BaseView : MonoBehaviour
    {
        bool _bindFlag = false;
        private bool isOpen = false;
        protected Entity mEntity;
        protected Button[] mbtns;
        protected abstract void InitBtns();
        protected virtual void Awake()
        {
            InitBtns();
        }
        protected void SetEntity(Entity entity)
        {
            mEntity = entity;
        }
        // Use this for initialization
        protected virtual void Start()
        {
            Open(null);

        }
        void bindBtnsListener()
        {
            if (_bindFlag || mbtns == null) return;
            _bindFlag = true;
            for (int i = 0; i < mbtns.Length; i++)
            {
                Button btn = mbtns[i];
                btn.onClick.AddListener(() => {
                    OnClicked(btn);
                });
            }
        }
        public void Open(Object param = null)
        {
            bindBtnsListener();
            gameObject.SetActive(true);
            if (isOpen) return;
            isOpen = true;
            OnOpen(param);
        }
        protected virtual void OnOpen(Object param = null) { }
        protected virtual void OnClose(Object param = null) { }
        
        public void Close(Object param = null)
        {
            gameObject.SetActive(false);
            if (!isOpen) return;
            isOpen = false;
            OnClose(param);
        }
        protected virtual void OnClicked(Button sender)
        {
            
        }
    }
}

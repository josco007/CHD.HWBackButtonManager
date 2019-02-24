using System;

namespace CHD
{
    public class HWBackButtonManager 
    {
        public static readonly HWBackButtonManager Instance = new HWBackButtonManager();

        public delegate bool OnBackButtonPressedDelegate();

        private OnBackButtonPressedDelegate onBackButtonPressedListener;

        private HWBackButtonManager()
        {

        }

        public bool NotifyHWBackButtonPressed()
        {

            if (onBackButtonPressedListener != null)
            {
                return onBackButtonPressedListener.Invoke();
            }

            return true; 
        }

        public void SetHWBackButtonListener(OnBackButtonPressedDelegate onBackButtonPressedListener)
        {
            this.onBackButtonPressedListener = onBackButtonPressedListener;
        }

        public void RemoveHWBackButtonListener()
        {
            onBackButtonPressedListener = null;
        } 
    }
}

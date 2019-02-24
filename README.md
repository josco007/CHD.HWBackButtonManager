# CHD.HWBackButtonManager
singlenton util to handle back button in a .NetStandard project




Usage:

On your pcl project page:

    protected override void OnAppearing()
    {
        base.OnAppearing();

        bool OnBackButtonPressed()
        {
            return false;
        }

        HWBackButtonManager.OnBackButtonPressedDelegate onBackButtonPressedDelegate = new HWBackButtonManager.OnBackButtonPressedDelegate(OnBackButtonPressed);

        HWBackButtonManager.Instance.SetHWBackButtonListener(onBackButtonPressedDelegate);
     

    }



    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        HWBackButtonManager.Instance.RemoveHWBackButtonListener();
    }
On your andriod MainActivity:

    public override void OnBackPressed()
    {


        if (!CHD.HWBackButtonManager.Instance.NotifyHWBackButtonPressed()){
            return;
        }

        base.OnBackPressed();
    }

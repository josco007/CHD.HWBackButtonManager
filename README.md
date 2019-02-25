# CHD.HWBackButtonManager
singlenton util to handle back button in a .NetStandard project


How to install:

You can install from the nuget manager in visual studio

nuget link: https://www.nuget.org/packages/CHD.HWBackButtonManager/#

Usage:

On your pcl project page:

    protected override void OnAppearing()
    {
        base.OnAppearing();

        bool OnBackButtonPressed()
        {
            return false; //false ignore backbutton
        }

        HWBackButtonManager.OnBackButtonPressedDelegate onBackButtonPressedDelegate = new HWBackButtonManager.OnBackButtonPressedDelegate(OnBackButtonPressed);

        HWBackButtonManager.Instance.SetHWBackButtonListener(onBackButtonPressedDelegate);
     

    }



    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        HWBackButtonManager.Instance.RemoveHWBackButtonListener(); // other pages allow backbutton
    }
On your andriod MainActivity:

    public override void OnBackPressed()
    {


        if (!CHD.HWBackButtonManager.Instance.NotifyHWBackButtonPressed()){
            return;
        }

        base.OnBackPressed();
    }

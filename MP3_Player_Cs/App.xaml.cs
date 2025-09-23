﻿namespace MP3_Player_Cs;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);

        // минимальный размер
        window.MinimumWidth = 1000;
        window.MinimumHeight = 600;

        return window;
    }
}


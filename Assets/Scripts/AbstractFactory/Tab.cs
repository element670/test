using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tab 
{
    public TabPresentation ViewingTabs()
    {
        TabPresentation tabPresentation = viewTab();
        tabPresentation.Show();
        return tabPresentation;
    }

    public abstract TabPresentation viewTab();
}

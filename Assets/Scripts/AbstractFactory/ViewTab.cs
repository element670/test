using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewTab : Tab
{
    public override TabPresentation viewTab()
    {
        return new ViewPresentation();
    }
}

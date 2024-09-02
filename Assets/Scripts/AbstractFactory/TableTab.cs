using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableTab : Tab
{
    public override TabPresentation viewTab()
    {
        return new ViewPresentation();
    }
}

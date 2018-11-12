﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[Serializable]
public class CommNetwork: Network
{
    /// <summary>
    /// Index of neighbor from which communication was recieved
    /// </summary>
    private int communicationFrom;
}
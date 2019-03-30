﻿// Artificial Life Simulator
// Copyright (c) 2019 Brett Layman
// This file is subject to the terms and conditions defined in 'LICENSE.txt', which is part of this source code repository.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// Maps a the value of the node (as calculated by NonInputNode methods) to an action.
/// </summary>
public class OutputNode : NonInputNode
{
    public Action action;
    public Creature parentCreature;

    public OutputNode() { }

    public OutputNode(Creature parentCreature, Network parentNet, int layer) : base(parentNet, layer)
    {

        activBehavior = new LogisticActivBehavior();
        this.parentCreature = parentCreature;
    }

    /// <summary>
    /// Adds its action to the action queue based on probability returned from the activation function.
    /// </summary>
    public void addActionIfActive()
    {
        parentCreature.actionQueue.Enqueue(action, action.priority);
    }

    // action is assigned using action pool of creature
    public void setAction(Action a)
    {
        action = a;
    }



}
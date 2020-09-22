﻿using System;
using OX.Persistence;
using System.Collections.Generic;
using static OX.Ledger.Blockchain;
using OX.Network.P2P.Payloads;
using System.Security.Permissions;
using OX.Wallets;
using OX.Bapps;

namespace OX.Bapps
{
    public interface IBappUi : IBappPort
    {
        Bapp Bapp { get; set; }
        IUIModule[] Modules { get; }
        void OnBlock(Block block);
        void OnBappEvent(BappEvent bappEvent);
        void OnCrossBappMessage(CrossBappMessage message);
    }

}
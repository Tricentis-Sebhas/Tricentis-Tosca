﻿using System;
using Tricentis.Automation.Execution;

namespace NeoLoad.Listener
{
    [Serializable]
    [TypeName("ExecutionEntry")]
    public class ExecutionEntryInfo
    {
        [MemberName(nameof(UniqueId))]
        public string UniqueId { get; set; }
        [MemberName(nameof(Name))]
        public string Name { get; set; }
        [MemberName(nameof(NodePath))]
        public string NodePath { get; set; }
        [MemberName(nameof(Revision))]
        public int Revision { get; set; }
    }
}
﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DocAsCode.Build.Engine.Incrementals
{
    using System.Collections.Generic;

    public class ProcessorInfo : ProcessorInfoBase
    {
        /// <summary>
        /// The information for steps.
        /// </summary>
        public List<ProcessorStepInfo> Steps { get; } = new List<ProcessorStepInfo>();
    }
}

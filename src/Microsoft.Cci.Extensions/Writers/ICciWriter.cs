﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Cci.Writers
{
    public interface ICciWriter
    {
        void WriteAssemblies(IEnumerable<IAssembly> assemblies);
    }
}

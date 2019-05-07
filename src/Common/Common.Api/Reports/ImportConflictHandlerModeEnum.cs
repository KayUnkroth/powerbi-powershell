﻿/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License.
 */

using System;

namespace Microsoft.PowerBI.Common.Api.Reports
{

    public enum ImportConflictHandlerModeEnum
    {
        Ignore,
        Abort,
        Overwrite,
        CreateOrOverwrite
    }
}
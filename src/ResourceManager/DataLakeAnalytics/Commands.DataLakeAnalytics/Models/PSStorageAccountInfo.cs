﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Management.DataLake.Analytics.Models;
using System;

namespace Microsoft.Azure.Commands.DataLakeAnalytics.Models
{
    /// <summary>
    ///    A wrapper for all ADLA supported data sources.
    ///    This object is returned from a GET
    /// </summary>
    public class PSStorageAccountInfo : StorageAccountInformation
    {
        [Obsolete("This property is no longer populated and will be removed in a future release")]
        public string AccessKey { get; set; }

        public PSStorageAccountInfo(StorageAccountInformation baseAccount) :
            base(
                id: baseAccount.Id,
                name: baseAccount.Name,
                type: baseAccount.Type,
                suffix: baseAccount.Suffix)
        { }
    }
}
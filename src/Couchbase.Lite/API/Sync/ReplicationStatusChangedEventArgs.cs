﻿// 
// ReplicationStatusChangedEventArgs.cs
// 
// Author:
//     Jim Borden  <jim.borden@couchbase.com>
// 
// Copyright (c) 2017 Couchbase, Inc All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
using System;

using JetBrains.Annotations;

namespace Couchbase.Lite.Sync
{
    /// <summary>
    /// Event arguments for the <see cref="Replicator.AddChangeListener(EventHandler{ReplicationStatusChangedEventArgs}" /> event
    /// </summary>
    public sealed class ReplicationStatusChangedEventArgs : EventArgs
    {
        #region Properties

        /// <summary>
        /// The new status for the <see cref="Replicator"/> in question.
        /// </summary>
        public ReplicationStatus Status { get; }

        #endregion

        #region Constructors

        internal ReplicationStatusChangedEventArgs(ReplicationStatus status)
        {
            Status = status;
        }

        #endregion
    }
}

﻿// cassandra-sharp - a .NET client for Apache Cassandra
// Copyright (c) 2011-2012 Pierre Chalamet
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

namespace CassandraSharp.Utils
{
    using System;
    using System.Diagnostics;

    public static class CheckParameterExtensions
    {
        [Conditional("DEBUG")]
        public static void CheckArgumentNotNull(this object prm, string name)
        {
            if (null == prm)
            {
                throw new ArgumentNullException(name);
            }
        }

        [Conditional("DEBUG")]
        public static void CheckArrayHasAtLeastOneElement<T>(this T[] prm, string name)
        {
            prm.CheckArgumentNotNull(name);
            if( 0 == prm.Length)
            {
                throw new ArgumentException(name);
            }
        }
    }
}
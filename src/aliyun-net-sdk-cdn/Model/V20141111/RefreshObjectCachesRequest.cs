/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cdn.Transform.V20141111;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class RefreshObjectCachesRequest : RpcAcsRequest<RefreshObjectCachesResponse>
    {
        public RefreshObjectCachesRequest()
            : base("Cdn", "2014-11-11", "RefreshObjectCaches")
        {
        }

		private long? _ownerId;

		private string _securityToken;

		private string _objectPath;

		private string _objectType;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string SecurityToken
		{
			get
			{
				return _securityToken;
			}
			set	
			{
				_securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string ObjectPath
		{
			get
			{
				return _objectPath;
			}
			set	
			{
				_objectPath = value;
				DictionaryUtil.Add(QueryParameters, "ObjectPath", value);
			}
		}

		public string ObjectType
		{
			get
			{
				return _objectType;
			}
			set	
			{
				_objectType = value;
				DictionaryUtil.Add(QueryParameters, "ObjectType", value);
			}
		}

        public override RefreshObjectCachesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return RefreshObjectCachesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
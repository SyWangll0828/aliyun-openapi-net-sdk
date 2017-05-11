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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Vod.Transform;
using Aliyun.Acs.Vod.Transform.V20170321;
using System.Collections.Generic;

namespace Aliyun.Acs.Vod.Model.V20170321
{
    public class GetOSSStatisRequest : RpcAcsRequest<GetOSSStatisResponse>
    {
        public GetOSSStatisRequest()
            : base("Vod", "2017-03-21", "GetOSSStatis")
        {
        }

		private string ownerId;

		private string resourceOwnerId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string startStatisTime;

		private string endStatisTime;

		private string level;

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		public string ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string StartStatisTime
		{
			get
			{
				return startStatisTime;
			}
			set	
			{
				startStatisTime = value;
				DictionaryUtil.Add(QueryParameters, "StartStatisTime", value);
			}
		}

		public string EndStatisTime
		{
			get
			{
				return endStatisTime;
			}
			set	
			{
				endStatisTime = value;
				DictionaryUtil.Add(QueryParameters, "EndStatisTime", value);
			}
		}

		public string Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
				DictionaryUtil.Add(QueryParameters, "Level", value);
			}
		}

        public override GetOSSStatisResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return GetOSSStatisResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
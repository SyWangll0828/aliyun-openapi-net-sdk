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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeClusterServiceResponseUnmarshaller
    {
        public static DescribeClusterServiceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeClusterServiceResponse describeClusterServiceResponse = new DescribeClusterServiceResponse();

			describeClusterServiceResponse.HttpResponse = context.HttpResponse;
			describeClusterServiceResponse.RequestId = context.StringValue("DescribeClusterService.RequestId");

			DescribeClusterServiceResponse.DescribeClusterService_ServiceInfo serviceInfo = new DescribeClusterServiceResponse.DescribeClusterService_ServiceInfo();
			serviceInfo.ServiceName = context.StringValue("DescribeClusterService.ServiceInfo.ServiceName");
			serviceInfo.ServiceVersion = context.StringValue("DescribeClusterService.ServiceInfo.ServiceVersion");
			serviceInfo.ServiceStatus = context.StringValue("DescribeClusterService.ServiceInfo.ServiceStatus");
			serviceInfo.NeedRestartInfo = context.StringValue("DescribeClusterService.ServiceInfo.NeedRestartInfo");
			serviceInfo.NeedRestartNum = context.IntegerValue("DescribeClusterService.ServiceInfo.NeedRestartNum");

			List<string> serviceInfo_needRestartHostIdList = new List<string>();
			for (int i = 0; i < context.Length("DescribeClusterService.ServiceInfo.NeedRestartHostIdList.Length"); i++) {
				serviceInfo_needRestartHostIdList.Add(context.StringValue("DescribeClusterService.ServiceInfo.NeedRestartHostIdList["+ i +"]"));
			}
			serviceInfo.NeedRestartHostIdList = serviceInfo_needRestartHostIdList;

			List<string> serviceInfo_needRestartComponentNameList = new List<string>();
			for (int i = 0; i < context.Length("DescribeClusterService.ServiceInfo.NeedRestartComponentNameList.Length"); i++) {
				serviceInfo_needRestartComponentNameList.Add(context.StringValue("DescribeClusterService.ServiceInfo.NeedRestartComponentNameList["+ i +"]"));
			}
			serviceInfo.NeedRestartComponentNameList = serviceInfo_needRestartComponentNameList;

			List<DescribeClusterServiceResponse.DescribeClusterService_ServiceInfo.DescribeClusterService_ServiceAction> serviceInfo_serviceActionList = new List<DescribeClusterServiceResponse.DescribeClusterService_ServiceInfo.DescribeClusterService_ServiceAction>();
			for (int i = 0; i < context.Length("DescribeClusterService.ServiceInfo.ServiceActionList.Length"); i++) {
				DescribeClusterServiceResponse.DescribeClusterService_ServiceInfo.DescribeClusterService_ServiceAction serviceAction = new DescribeClusterServiceResponse.DescribeClusterService_ServiceInfo.DescribeClusterService_ServiceAction();
				serviceAction.ServiceName = context.StringValue("DescribeClusterService.ServiceInfo.ServiceActionList["+ i +"].ServiceName");
				serviceAction.ComponentName = context.StringValue("DescribeClusterService.ServiceInfo.ServiceActionList["+ i +"].ComponentName");
				serviceAction.ActionName = context.StringValue("DescribeClusterService.ServiceInfo.ServiceActionList["+ i +"].ActionName");
				serviceAction.Command = context.StringValue("DescribeClusterService.ServiceInfo.ServiceActionList["+ i +"].Command");
				serviceAction.DisplayName = context.StringValue("DescribeClusterService.ServiceInfo.ServiceActionList["+ i +"].DisplayName");

				serviceInfo_serviceActionList.Add(serviceAction);
			}
			serviceInfo.ServiceActionList = serviceInfo_serviceActionList;

			List<DescribeClusterServiceResponse.DescribeClusterService_ServiceInfo.DescribeClusterService_ClusterServiceSummary> serviceInfo_clusterServiceSummaryList = new List<DescribeClusterServiceResponse.DescribeClusterService_ServiceInfo.DescribeClusterService_ClusterServiceSummary>();
			for (int i = 0; i < context.Length("DescribeClusterService.ServiceInfo.ClusterServiceSummaryList.Length"); i++) {
				DescribeClusterServiceResponse.DescribeClusterService_ServiceInfo.DescribeClusterService_ClusterServiceSummary clusterServiceSummary = new DescribeClusterServiceResponse.DescribeClusterService_ServiceInfo.DescribeClusterService_ClusterServiceSummary();
				clusterServiceSummary.Key = context.StringValue("DescribeClusterService.ServiceInfo.ClusterServiceSummaryList["+ i +"].Key");
				clusterServiceSummary.DisplayName = context.StringValue("DescribeClusterService.ServiceInfo.ClusterServiceSummaryList["+ i +"].DisplayName");
				clusterServiceSummary._Value = context.StringValue("DescribeClusterService.ServiceInfo.ClusterServiceSummaryList["+ i +"].Value");
				clusterServiceSummary.DesiredStoppedValue = context.IntegerValue("DescribeClusterService.ServiceInfo.ClusterServiceSummaryList["+ i +"].DesiredStoppedValue");
				clusterServiceSummary.Status = context.StringValue("DescribeClusterService.ServiceInfo.ClusterServiceSummaryList["+ i +"].Status");
				clusterServiceSummary.Type = context.StringValue("DescribeClusterService.ServiceInfo.ClusterServiceSummaryList["+ i +"].Type");
				clusterServiceSummary.Category = context.StringValue("DescribeClusterService.ServiceInfo.ClusterServiceSummaryList["+ i +"].Category");
				clusterServiceSummary.AlertInfo = context.StringValue("DescribeClusterService.ServiceInfo.ClusterServiceSummaryList["+ i +"].AlertInfo");

				serviceInfo_clusterServiceSummaryList.Add(clusterServiceSummary);
			}
			serviceInfo.ClusterServiceSummaryList = serviceInfo_clusterServiceSummaryList;
			describeClusterServiceResponse.ServiceInfo = serviceInfo;
        
			return describeClusterServiceResponse;
        }
    }
}

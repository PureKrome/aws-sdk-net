/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AuthorizeClientVpnIngress Request Marshaller
    /// </summary>       
    public class AuthorizeClientVpnIngressRequestMarshaller : IMarshaller<IRequest, AuthorizeClientVpnIngressRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AuthorizeClientVpnIngressRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AuthorizeClientVpnIngressRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "AuthorizeClientVpnIngress");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAccessGroupId())
                {
                    request.Parameters.Add("AccessGroupId", StringUtils.FromString(publicRequest.AccessGroupId));
                }
                if(publicRequest.IsSetAuthorizeAllGroups())
                {
                    request.Parameters.Add("AuthorizeAllGroups", StringUtils.FromBool(publicRequest.AuthorizeAllGroups));
                }
                if(publicRequest.IsSetClientVpnEndpointId())
                {
                    request.Parameters.Add("ClientVpnEndpointId", StringUtils.FromString(publicRequest.ClientVpnEndpointId));
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetTargetNetworkCidr())
                {
                    request.Parameters.Add("TargetNetworkCidr", StringUtils.FromString(publicRequest.TargetNetworkCidr));
                }
            }
            return request;
        }
                    private static AuthorizeClientVpnIngressRequestMarshaller _instance = new AuthorizeClientVpnIngressRequestMarshaller();        

        internal static AuthorizeClientVpnIngressRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AuthorizeClientVpnIngressRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
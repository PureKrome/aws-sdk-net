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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetInstanceMetricData operation.
    /// Returns the data points for the specified Amazon Lightsail instance metric, given
    /// an instance name.
    /// </summary>
    public partial class GetInstanceMetricDataRequest : AmazonLightsailRequest
    {
        private DateTime? _endTime;
        private string _instanceName;
        private InstanceMetricName _metricName;
        private int? _period;
        private DateTime? _startTime;
        private List<string> _statistics = new List<string>();
        private MetricUnit _unit;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the time period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the instance for which you want to get metrics data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The metric for which you want to return information.
        /// </para>
        ///  
        /// <para>
        /// Valid instance metric names are listed below, along with the most useful <code>statistics</code>
        /// to include in your request, and the published <code>unit</code> value.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>CPUUtilization</code> </b> - The percentage of allocated compute units
        /// that are currently in use on the instance. This metric identifies the processing power
        /// to run the applications on the instance. Tools in your operating system can show a
        /// lower percentage than Lightsail when the instance is not allocated a full processor
        /// core.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistics are <code>Maximum</code> and
        /// <code>Average</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Percent</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>NetworkIn</code> </b> - The number of bytes received on all network interfaces
        /// by the instance. This metric identifies the volume of incoming network traffic to
        /// the instance. The number reported is the number of bytes received during the period.
        /// Because this metric is reported in 5-minute intervals, divide the reported number
        /// by 300 to find Bytes/second.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Bytes</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>NetworkOut</code> </b> - The number of bytes sent out on all network interfaces
        /// by the instance. This metric identifies the volume of outgoing network traffic from
        /// the instance. The number reported is the number of bytes sent during the period. Because
        /// this metric is reported in 5-minute intervals, divide the reported number by 300 to
        /// find Bytes/second.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Bytes</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>StatusCheckFailed</code> </b> - Reports whether the instance passed or
        /// failed both the instance status check and the system status check. This metric can
        /// be either 0 (passed) or 1 (failed). This metric data is available in 1-minute (60
        /// seconds) granularity.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>StatusCheckFailed_Instance</code> </b> - Reports whether the instance passed
        /// or failed the instance status check. This metric can be either 0 (passed) or 1 (failed).
        /// This metric data is available in 1-minute (60 seconds) granularity.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>StatusCheckFailed_System</code> </b> - Reports whether the instance passed
        /// or failed the system status check. This metric can be either 0 (passed) or 1 (failed).
        /// This metric data is available in 1-minute (60 seconds) granularity.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceMetricName MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The granularity, in seconds, of the returned data points.
        /// </para>
        ///  
        /// <para>
        /// The <code>StatusCheckFailed</code>, <code>StatusCheckFailed_Instance</code>, and <code>StatusCheckFailed_System</code>
        /// instance metric data is available in 1-minute (60 seconds) granularity. All other
        /// instance metric data is available in 5-minute (300 seconds) granularity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=86400)]
        public int Period
        {
            get { return this._period.GetValueOrDefault(); }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the time period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The statistic for the metric.
        /// </para>
        ///  
        /// <para>
        /// The following statistics are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Minimum</code> - The lowest value observed during the specified period. Use
        /// this value to determine low volumes of activity for your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Maximum</code> - The highest value observed during the specified period. Use
        /// this value to determine high volumes of activity for your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Sum</code> - All values submitted for the matching metric added together. You
        /// can use this statistic to determine the total volume of a metric.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Average</code> - The value of Sum / SampleCount during the specified period.
        /// By comparing this statistic with the Minimum and Maximum values, you can determine
        /// the full scope of a metric and how close the average use is to the Minimum and Maximum
        /// values. This comparison helps you to know when to increase or decrease your resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SampleCount</code> - The count, or number, of data points used for the statistical
        /// calculation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null && this._statistics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit for the metric data request. Valid units depend on the metric data being
        /// requested. For the valid units to specify with each available metric, see the <code>metricName</code>
        /// parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}
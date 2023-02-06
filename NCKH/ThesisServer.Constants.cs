/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace ThesisServer
{
    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the Plant1 Object.
        /// </summary>
        public const uint Plant1 = 15098;

        /// <summary>
        /// The identifier for the Plant1_System1 Object.
        /// </summary>
        public const uint Plant1_System1 = 15099;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice = 15100;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200 Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200 = 15101;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters = 15102;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100 Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100 = 15113;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters = 15114;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_VFD = 15125;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDRead Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_VFD_VFDRead = 15126;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDWrite Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_VFD_VFDWrite = 15132;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8 Object.
        /// </summary>
        public const uint Plant1_System1_LOGO8 = 15135;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight Object.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLight = 15136;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount Object.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLightCount = 15149;

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController Object.
        /// </summary>
        public const uint Plant1_System1_SpeedController = 15162;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the GenericControllerType ObjectType.
        /// </summary>
        public const uint GenericControllerType = 15001;

        /// <summary>
        /// The identifier for the AnalogInputType1 ObjectType.
        /// </summary>
        public const uint AnalogInputType1 = 15006;

        /// <summary>
        /// The identifier for the AnalogInputType2 ObjectType.
        /// </summary>
        public const uint AnalogInputType2 = 15017;

        /// <summary>
        /// The identifier for the AnalogInputType3 ObjectType.
        /// </summary>
        public const uint AnalogInputType3 = 15023;

        /// <summary>
        /// The identifier for the AnalogOutputType ObjectType.
        /// </summary>
        public const uint AnalogOutputType = 15036;

        /// <summary>
        /// The identifier for the DigitalType ObjectType.
        /// </summary>
        public const uint DigitalType = 15039;

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public const uint ValveType = 15052;

        /// <summary>
        /// The identifier for the AnalogSensorType1 ObjectType.
        /// </summary>
        public const uint AnalogSensorType1 = 15055;

        /// <summary>
        /// The identifier for the AnalogSensorType2 ObjectType.
        /// </summary>
        public const uint AnalogSensorType2 = 15066;

        /// <summary>
        /// The identifier for the AnalogSensorType3 ObjectType.
        /// </summary>
        public const uint AnalogSensorType3 = 15072;

        /// <summary>
        /// The identifier for the ButtonType ObjectType.
        /// </summary>
        public const uint ButtonType = 15085;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the GenericControllerType_SetPoint Variable.
        /// </summary>
        public const uint GenericControllerType_SetPoint = 15002;

        /// <summary>
        /// The identifier for the GenericControllerType_Kp Variable.
        /// </summary>
        public const uint GenericControllerType_Kp = 15003;

        /// <summary>
        /// The identifier for the GenericControllerType_Ki Variable.
        /// </summary>
        public const uint GenericControllerType_Ki = 15004;

        /// <summary>
        /// The identifier for the GenericControllerType_Kd Variable.
        /// </summary>
        public const uint GenericControllerType_Kd = 15005;

        /// <summary>
        /// The identifier for the AnalogInputType1_Output Variable.
        /// </summary>
        public const uint AnalogInputType1_Output = 15007;

        /// <summary>
        /// The identifier for the AnalogInputType1_Ampere Variable.
        /// </summary>
        public const uint AnalogInputType1_Ampere = 15008;

        /// <summary>
        /// The identifier for the AnalogInputType1_AmpereStatus Variable.
        /// </summary>
        public const uint AnalogInputType1_AmpereStatus = 15009;

        /// <summary>
        /// The identifier for the AnalogInputType1_Volt Variable.
        /// </summary>
        public const uint AnalogInputType1_Volt = 15010;

        /// <summary>
        /// The identifier for the AnalogInputType1_VoltStatus Variable.
        /// </summary>
        public const uint AnalogInputType1_VoltStatus = 15011;

        /// <summary>
        /// The identifier for the AnalogInputType1_Frequency Variable.
        /// </summary>
        public const uint AnalogInputType1_Frequency = 15012;

        /// <summary>
        /// The identifier for the AnalogInputType1_Power Variable.
        /// </summary>
        public const uint AnalogInputType1_Power = 15013;

        /// <summary>
        /// The identifier for the AnalogInputType1_PowerStatus Variable.
        /// </summary>
        public const uint AnalogInputType1_PowerStatus = 15014;

        /// <summary>
        /// The identifier for the AnalogInputType1_PowerFactor Variable.
        /// </summary>
        public const uint AnalogInputType1_PowerFactor = 15015;

        /// <summary>
        /// The identifier for the AnalogInputType1_Status Variable.
        /// </summary>
        public const uint AnalogInputType1_Status = 15016;

        /// <summary>
        /// The identifier for the AnalogInputType2_FrequencyCommand Variable.
        /// </summary>
        public const uint AnalogInputType2_FrequencyCommand = 15018;

        /// <summary>
        /// The identifier for the AnalogInputType2_FrequencyOutput Variable.
        /// </summary>
        public const uint AnalogInputType2_FrequencyOutput = 15019;

        /// <summary>
        /// The identifier for the AnalogInputType2_CurrentOutput Variable.
        /// </summary>
        public const uint AnalogInputType2_CurrentOutput = 15020;

        /// <summary>
        /// The identifier for the AnalogInputType2_VoltageCommand Variable.
        /// </summary>
        public const uint AnalogInputType2_VoltageCommand = 15021;

        /// <summary>
        /// The identifier for the AnalogInputType2_DCBusVoltage Variable.
        /// </summary>
        public const uint AnalogInputType2_DCBusVoltage = 15022;

        /// <summary>
        /// The identifier for the AnalogInputType3_Green1Count Variable.
        /// </summary>
        public const uint AnalogInputType3_Green1Count = 15024;

        /// <summary>
        /// The identifier for the AnalogInputType3_Yellow1Count Variable.
        /// </summary>
        public const uint AnalogInputType3_Yellow1Count = 15025;

        /// <summary>
        /// The identifier for the AnalogInputType3_Red1Count Variable.
        /// </summary>
        public const uint AnalogInputType3_Red1Count = 15026;

        /// <summary>
        /// The identifier for the AnalogInputType3_Green2Count Variable.
        /// </summary>
        public const uint AnalogInputType3_Green2Count = 15027;

        /// <summary>
        /// The identifier for the AnalogInputType3_Yellow2Count Variable.
        /// </summary>
        public const uint AnalogInputType3_Yellow2Count = 15028;

        /// <summary>
        /// The identifier for the AnalogInputType3_Red2Count Variable.
        /// </summary>
        public const uint AnalogInputType3_Red2Count = 15029;

        /// <summary>
        /// The identifier for the AnalogInputType3_Green3Count Variable.
        /// </summary>
        public const uint AnalogInputType3_Green3Count = 15030;

        /// <summary>
        /// The identifier for the AnalogInputType3_Yellow3Count Variable.
        /// </summary>
        public const uint AnalogInputType3_Yellow3Count = 15031;

        /// <summary>
        /// The identifier for the AnalogInputType3_Red3Count Variable.
        /// </summary>
        public const uint AnalogInputType3_Red3Count = 15032;

        /// <summary>
        /// The identifier for the AnalogInputType3_Green4Count Variable.
        /// </summary>
        public const uint AnalogInputType3_Green4Count = 15033;

        /// <summary>
        /// The identifier for the AnalogInputType3_Yellow4Count Variable.
        /// </summary>
        public const uint AnalogInputType3_Yellow4Count = 15034;

        /// <summary>
        /// The identifier for the AnalogInputType3_Red4Count Variable.
        /// </summary>
        public const uint AnalogInputType3_Red4Count = 15035;

        /// <summary>
        /// The identifier for the AnalogOutputType_FrequencyWrite Variable.
        /// </summary>
        public const uint AnalogOutputType_FrequencyWrite = 15037;

        /// <summary>
        /// The identifier for the AnalogOutputType_ControlRunWrite Variable.
        /// </summary>
        public const uint AnalogOutputType_ControlRunWrite = 15038;

        /// <summary>
        /// The identifier for the DigitalType_Green1 Variable.
        /// </summary>
        public const uint DigitalType_Green1 = 15040;

        /// <summary>
        /// The identifier for the DigitalType_Yellow1 Variable.
        /// </summary>
        public const uint DigitalType_Yellow1 = 15041;

        /// <summary>
        /// The identifier for the DigitalType_Red1 Variable.
        /// </summary>
        public const uint DigitalType_Red1 = 15042;

        /// <summary>
        /// The identifier for the DigitalType_Green2 Variable.
        /// </summary>
        public const uint DigitalType_Green2 = 15043;

        /// <summary>
        /// The identifier for the DigitalType_Yellow2 Variable.
        /// </summary>
        public const uint DigitalType_Yellow2 = 15044;

        /// <summary>
        /// The identifier for the DigitalType_Red2 Variable.
        /// </summary>
        public const uint DigitalType_Red2 = 15045;

        /// <summary>
        /// The identifier for the DigitalType_Green3 Variable.
        /// </summary>
        public const uint DigitalType_Green3 = 15046;

        /// <summary>
        /// The identifier for the DigitalType_Yellow3 Variable.
        /// </summary>
        public const uint DigitalType_Yellow3 = 15047;

        /// <summary>
        /// The identifier for the DigitalType_Red3 Variable.
        /// </summary>
        public const uint DigitalType_Red3 = 15048;

        /// <summary>
        /// The identifier for the DigitalType_Green4 Variable.
        /// </summary>
        public const uint DigitalType_Green4 = 15049;

        /// <summary>
        /// The identifier for the DigitalType_Yellow4 Variable.
        /// </summary>
        public const uint DigitalType_Yellow4 = 15050;

        /// <summary>
        /// The identifier for the DigitalType_Red4 Variable.
        /// </summary>
        public const uint DigitalType_Red4 = 15051;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Output Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Output = 15103;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Ampere Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Ampere = 15104;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_AmpereStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_AmpereStatus = 15105;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Volt Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Volt = 15106;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_VoltStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_VoltStatus = 15107;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Frequency Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Frequency = 15108;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Power Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Power = 15109;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerStatus = 15110;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerFactor Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerFactor = 15111;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Status Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Status = 15112;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Output Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Output = 15115;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Ampere Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Ampere = 15116;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_AmpereStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_AmpereStatus = 15117;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Volt Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Volt = 15118;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_VoltStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_VoltStatus = 15119;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Frequency Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Frequency = 15120;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Power Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Power = 15121;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerStatus = 15122;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerFactor Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerFactor = 15123;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Status Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Status = 15124;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDRead_FrequencyCommand Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_VFD_VFDRead_FrequencyCommand = 15127;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDRead_FrequencyOutput Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_VFD_VFDRead_FrequencyOutput = 15128;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDRead_CurrentOutput Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_VFD_VFDRead_CurrentOutput = 15129;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDRead_VoltageCommand Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_VFD_VFDRead_VoltageCommand = 15130;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDRead_DCBusVoltage Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_VFD_VFDRead_DCBusVoltage = 15131;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDWrite_FrequencyWrite Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_VFD_VFDWrite_FrequencyWrite = 15133;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDWrite_ControlRunWrite Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_VFD_VFDWrite_ControlRunWrite = 15134;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Green1 Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLight_Green1 = 15137;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Yellow1 Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLight_Yellow1 = 15138;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Red1 Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLight_Red1 = 15139;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Green2 Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLight_Green2 = 15140;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Yellow2 Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLight_Yellow2 = 15141;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Red2 Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLight_Red2 = 15142;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Green3 Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLight_Green3 = 15143;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Yellow3 Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLight_Yellow3 = 15144;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Red3 Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLight_Red3 = 15145;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Green4 Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLight_Green4 = 15146;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Yellow4 Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLight_Yellow4 = 15147;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Red4 Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLight_Red4 = 15148;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Green1Count Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLightCount_Green1Count = 15150;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Yellow1Count Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLightCount_Yellow1Count = 15151;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Red1Count Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLightCount_Red1Count = 15152;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Green2Count Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLightCount_Green2Count = 15153;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Yellow2Count Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLightCount_Yellow2Count = 15154;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Red2Count Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLightCount_Red2Count = 15155;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Green3Count Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLightCount_Green3Count = 15156;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Yellow3Count Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLightCount_Yellow3Count = 15157;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Red3Count Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLightCount_Red3Count = 15158;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Green4Count Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLightCount_Green4Count = 15159;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Yellow4Count Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLightCount_Yellow4Count = 15160;

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Red4Count Variable.
        /// </summary>
        public const uint Plant1_System1_LOGO8_TrafficLightCount_Red4Count = 15161;

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_SetPoint Variable.
        /// </summary>
        public const uint Plant1_System1_SpeedController_SetPoint = 15163;

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Kp Variable.
        /// </summary>
        public const uint Plant1_System1_SpeedController_Kp = 15164;

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Ki Variable.
        /// </summary>
        public const uint Plant1_System1_SpeedController_Ki = 15165;

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Kd Variable.
        /// </summary>
        public const uint Plant1_System1_SpeedController_Kd = 15166;
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the Plant1 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1 = new ExpandedNodeId(ThesisServer.Objects.Plant1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1 = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200 = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice_PM1200, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100 = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice_PM2100, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_VFD = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice_VFD, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDRead Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_VFD_VFDRead = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice_VFD_VFDRead, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDWrite Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_VFD_VFDWrite = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice_VFD_VFDWrite, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8 = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_LOGO8, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLight = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_LOGO8_TrafficLight, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLightCount = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_LOGO8_TrafficLightCount, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_SpeedController = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_SpeedController, ThesisServer.Namespaces.ThesisServer);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the GenericControllerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType = new ExpandedNodeId(ThesisServer.ObjectTypes.GenericControllerType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType1 ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType1 = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogInputType1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType2 ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType2 = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogInputType2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType3 ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType3 = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogInputType3, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogOutputType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogOutputType = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogOutputType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType = new ExpandedNodeId(ThesisServer.ObjectTypes.DigitalType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ValveType = new ExpandedNodeId(ThesisServer.ObjectTypes.ValveType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogSensorType1 ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorType1 = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogSensorType1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogSensorType2 ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorType2 = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogSensorType2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogSensorType3 ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorType3 = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogSensorType3, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the ButtonType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ButtonType = new ExpandedNodeId(ThesisServer.ObjectTypes.ButtonType, ThesisServer.Namespaces.ThesisServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the GenericControllerType_SetPoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_SetPoint = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_SetPoint, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the GenericControllerType_Kp Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_Kp = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_Kp, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the GenericControllerType_Ki Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_Ki = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_Ki, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the GenericControllerType_Kd Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_Kd = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_Kd, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType1_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType1_Output = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType1_Output, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType1_Ampere Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType1_Ampere = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType1_Ampere, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType1_AmpereStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType1_AmpereStatus = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType1_AmpereStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType1_Volt Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType1_Volt = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType1_Volt, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType1_VoltStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType1_VoltStatus = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType1_VoltStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType1_Frequency Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType1_Frequency = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType1_Frequency, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType1_Power Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType1_Power = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType1_Power, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType1_PowerStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType1_PowerStatus = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType1_PowerStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType1_PowerFactor Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType1_PowerFactor = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType1_PowerFactor, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType1_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType1_Status = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType1_Status, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType2_FrequencyCommand Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType2_FrequencyCommand = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType2_FrequencyCommand, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType2_FrequencyOutput Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType2_FrequencyOutput = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType2_FrequencyOutput, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType2_CurrentOutput Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType2_CurrentOutput = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType2_CurrentOutput, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType2_VoltageCommand Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType2_VoltageCommand = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType2_VoltageCommand, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType2_DCBusVoltage Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType2_DCBusVoltage = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType2_DCBusVoltage, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType3_Green1Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType3_Green1Count = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType3_Green1Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType3_Yellow1Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType3_Yellow1Count = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType3_Yellow1Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType3_Red1Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType3_Red1Count = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType3_Red1Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType3_Green2Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType3_Green2Count = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType3_Green2Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType3_Yellow2Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType3_Yellow2Count = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType3_Yellow2Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType3_Red2Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType3_Red2Count = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType3_Red2Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType3_Green3Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType3_Green3Count = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType3_Green3Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType3_Yellow3Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType3_Yellow3Count = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType3_Yellow3Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType3_Red3Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType3_Red3Count = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType3_Red3Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType3_Green4Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType3_Green4Count = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType3_Green4Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType3_Yellow4Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType3_Yellow4Count = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType3_Yellow4Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType3_Red4Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType3_Red4Count = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType3_Red4Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogOutputType_FrequencyWrite Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogOutputType_FrequencyWrite = new ExpandedNodeId(ThesisServer.Variables.AnalogOutputType_FrequencyWrite, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogOutputType_ControlRunWrite Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogOutputType_ControlRunWrite = new ExpandedNodeId(ThesisServer.Variables.AnalogOutputType_ControlRunWrite, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType_Green1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Green1 = new ExpandedNodeId(ThesisServer.Variables.DigitalType_Green1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType_Yellow1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Yellow1 = new ExpandedNodeId(ThesisServer.Variables.DigitalType_Yellow1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType_Red1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Red1 = new ExpandedNodeId(ThesisServer.Variables.DigitalType_Red1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType_Green2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Green2 = new ExpandedNodeId(ThesisServer.Variables.DigitalType_Green2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType_Yellow2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Yellow2 = new ExpandedNodeId(ThesisServer.Variables.DigitalType_Yellow2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType_Red2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Red2 = new ExpandedNodeId(ThesisServer.Variables.DigitalType_Red2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType_Green3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Green3 = new ExpandedNodeId(ThesisServer.Variables.DigitalType_Green3, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType_Yellow3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Yellow3 = new ExpandedNodeId(ThesisServer.Variables.DigitalType_Yellow3, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType_Red3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Red3 = new ExpandedNodeId(ThesisServer.Variables.DigitalType_Red3, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType_Green4 Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Green4 = new ExpandedNodeId(ThesisServer.Variables.DigitalType_Green4, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType_Yellow4 Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Yellow4 = new ExpandedNodeId(ThesisServer.Variables.DigitalType_Yellow4, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType_Red4 Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Red4 = new ExpandedNodeId(ThesisServer.Variables.DigitalType_Red4, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Output = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Output, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Ampere Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Ampere = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Ampere, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_AmpereStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_AmpereStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_AmpereStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Volt Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Volt = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Volt, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_VoltStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_VoltStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_VoltStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Frequency Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Frequency = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Frequency, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Power Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Power = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Power, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerFactor Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerFactor = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerFactor, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Status = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Status, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Output = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Output, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Ampere Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Ampere = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Ampere, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_AmpereStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_AmpereStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_AmpereStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Volt Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Volt = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Volt, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_VoltStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_VoltStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_VoltStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Frequency Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Frequency = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Frequency, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Power Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Power = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Power, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerFactor Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerFactor = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerFactor, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Status = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Status, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDRead_FrequencyCommand Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_VFD_VFDRead_FrequencyCommand = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_VFD_VFDRead_FrequencyCommand, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDRead_FrequencyOutput Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_VFD_VFDRead_FrequencyOutput = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_VFD_VFDRead_FrequencyOutput, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDRead_CurrentOutput Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_VFD_VFDRead_CurrentOutput = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_VFD_VFDRead_CurrentOutput, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDRead_VoltageCommand Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_VFD_VFDRead_VoltageCommand = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_VFD_VFDRead_VoltageCommand, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDRead_DCBusVoltage Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_VFD_VFDRead_DCBusVoltage = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_VFD_VFDRead_DCBusVoltage, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDWrite_FrequencyWrite Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_VFD_VFDWrite_FrequencyWrite = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_VFD_VFDWrite_FrequencyWrite, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_VFD_VFDWrite_ControlRunWrite Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_VFD_VFDWrite_ControlRunWrite = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_VFD_VFDWrite_ControlRunWrite, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Green1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLight_Green1 = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLight_Green1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Yellow1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLight_Yellow1 = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLight_Yellow1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Red1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLight_Red1 = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLight_Red1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Green2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLight_Green2 = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLight_Green2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Yellow2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLight_Yellow2 = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLight_Yellow2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Red2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLight_Red2 = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLight_Red2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Green3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLight_Green3 = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLight_Green3, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Yellow3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLight_Yellow3 = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLight_Yellow3, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Red3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLight_Red3 = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLight_Red3, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Green4 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLight_Green4 = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLight_Green4, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Yellow4 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLight_Yellow4 = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLight_Yellow4, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLight_Red4 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLight_Red4 = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLight_Red4, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Green1Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLightCount_Green1Count = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLightCount_Green1Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Yellow1Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLightCount_Yellow1Count = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLightCount_Yellow1Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Red1Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLightCount_Red1Count = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLightCount_Red1Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Green2Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLightCount_Green2Count = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLightCount_Green2Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Yellow2Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLightCount_Yellow2Count = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLightCount_Yellow2Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Red2Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLightCount_Red2Count = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLightCount_Red2Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Green3Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLightCount_Green3Count = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLightCount_Green3Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Yellow3Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLightCount_Yellow3Count = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLightCount_Yellow3Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Red3Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLightCount_Red3Count = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLightCount_Red3Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Green4Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLightCount_Green4Count = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLightCount_Green4Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Yellow4Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLightCount_Yellow4Count = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLightCount_Yellow4Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_LOGO8_TrafficLightCount_Red4Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_LOGO8_TrafficLightCount_Red4Count = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_LOGO8_TrafficLightCount_Red4Count, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_SetPoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_SpeedController_SetPoint = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_SpeedController_SetPoint, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Kp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_SpeedController_Kp = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_SpeedController_Kp, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Ki Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_SpeedController_Ki = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_SpeedController_Ki, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Kd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_SpeedController_Kd = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_SpeedController_Kd, ThesisServer.Namespaces.ThesisServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Ampere component.
        /// </summary>
        public const string Ampere = "Ampere";

        /// <summary>
        /// The BrowseName for the AmpereStatus component.
        /// </summary>
        public const string AmpereStatus = "AmpereStatus";

        /// <summary>
        /// The BrowseName for the AnalogInputType1 component.
        /// </summary>
        public const string AnalogInputType1 = "AnalogInputType1";

        /// <summary>
        /// The BrowseName for the AnalogInputType2 component.
        /// </summary>
        public const string AnalogInputType2 = "AnalogInputType2";

        /// <summary>
        /// The BrowseName for the AnalogInputType3 component.
        /// </summary>
        public const string AnalogInputType3 = "AnalogInputType3";

        /// <summary>
        /// The BrowseName for the AnalogOutputType component.
        /// </summary>
        public const string AnalogOutputType = "AnalogOutputType";

        /// <summary>
        /// The BrowseName for the AnalogSensorType1 component.
        /// </summary>
        public const string AnalogSensorType1 = "AnalogSensorType1";

        /// <summary>
        /// The BrowseName for the AnalogSensorType2 component.
        /// </summary>
        public const string AnalogSensorType2 = "AnalogSensorType2";

        /// <summary>
        /// The BrowseName for the AnalogSensorType3 component.
        /// </summary>
        public const string AnalogSensorType3 = "AnalogSensorType3";

        /// <summary>
        /// The BrowseName for the ButtonType component.
        /// </summary>
        public const string ButtonType = "ButtonType";

        /// <summary>
        /// The BrowseName for the ControlRunWrite component.
        /// </summary>
        public const string ControlRunWrite = "ControlRunWrite";

        /// <summary>
        /// The BrowseName for the CurrentOutput component.
        /// </summary>
        public const string CurrentOutput = "CurrentOutput";

        /// <summary>
        /// The BrowseName for the DCBusVoltage component.
        /// </summary>
        public const string DCBusVoltage = "DCBusVoltage";

        /// <summary>
        /// The BrowseName for the DigitalType component.
        /// </summary>
        public const string DigitalType = "DigitalType";

        /// <summary>
        /// The BrowseName for the Frequency component.
        /// </summary>
        public const string Frequency = "Frequency";

        /// <summary>
        /// The BrowseName for the FrequencyCommand component.
        /// </summary>
        public const string FrequencyCommand = "FrequencyCommand";

        /// <summary>
        /// The BrowseName for the FrequencyOutput component.
        /// </summary>
        public const string FrequencyOutput = "FrequencyOutput";

        /// <summary>
        /// The BrowseName for the FrequencyWrite component.
        /// </summary>
        public const string FrequencyWrite = "FrequencyWrite";

        /// <summary>
        /// The BrowseName for the GenericControllerType component.
        /// </summary>
        public const string GenericControllerType = "GenericControllerType";

        /// <summary>
        /// The BrowseName for the Green1 component.
        /// </summary>
        public const string Green1 = "Green1";

        /// <summary>
        /// The BrowseName for the Green1Count component.
        /// </summary>
        public const string Green1Count = "Green1Count";

        /// <summary>
        /// The BrowseName for the Green2 component.
        /// </summary>
        public const string Green2 = "Green2";

        /// <summary>
        /// The BrowseName for the Green2Count component.
        /// </summary>
        public const string Green2Count = "Green2Count";

        /// <summary>
        /// The BrowseName for the Green3 component.
        /// </summary>
        public const string Green3 = "Green3";

        /// <summary>
        /// The BrowseName for the Green3Count component.
        /// </summary>
        public const string Green3Count = "Green3Count";

        /// <summary>
        /// The BrowseName for the Green4 component.
        /// </summary>
        public const string Green4 = "Green4";

        /// <summary>
        /// The BrowseName for the Green4Count component.
        /// </summary>
        public const string Green4Count = "Green4Count";

        /// <summary>
        /// The BrowseName for the Kd component.
        /// </summary>
        public const string Kd = "Kd";

        /// <summary>
        /// The BrowseName for the Ki component.
        /// </summary>
        public const string Ki = "Ki";

        /// <summary>
        /// The BrowseName for the Kp component.
        /// </summary>
        public const string Kp = "Kp";

        /// <summary>
        /// The BrowseName for the Output component.
        /// </summary>
        public const string Output = "Output";

        /// <summary>
        /// The BrowseName for the Plant1 component.
        /// </summary>
        public const string Plant1 = "Plant 1";

        /// <summary>
        /// The BrowseName for the Power component.
        /// </summary>
        public const string Power = "Power";

        /// <summary>
        /// The BrowseName for the PowerFactor component.
        /// </summary>
        public const string PowerFactor = "PowerFactor";

        /// <summary>
        /// The BrowseName for the PowerStatus component.
        /// </summary>
        public const string PowerStatus = "PowerStatus";

        /// <summary>
        /// The BrowseName for the Red1 component.
        /// </summary>
        public const string Red1 = "Red1";

        /// <summary>
        /// The BrowseName for the Red1Count component.
        /// </summary>
        public const string Red1Count = "Red1Count";

        /// <summary>
        /// The BrowseName for the Red2 component.
        /// </summary>
        public const string Red2 = "Red2";

        /// <summary>
        /// The BrowseName for the Red2Count component.
        /// </summary>
        public const string Red2Count = "Red2Count";

        /// <summary>
        /// The BrowseName for the Red3 component.
        /// </summary>
        public const string Red3 = "Red3";

        /// <summary>
        /// The BrowseName for the Red3Count component.
        /// </summary>
        public const string Red3Count = "Red3Count";

        /// <summary>
        /// The BrowseName for the Red4 component.
        /// </summary>
        public const string Red4 = "Red4";

        /// <summary>
        /// The BrowseName for the Red4Count component.
        /// </summary>
        public const string Red4Count = "Red4Count";

        /// <summary>
        /// The BrowseName for the SetPoint component.
        /// </summary>
        public const string SetPoint = "SetPoint";

        /// <summary>
        /// The BrowseName for the Status component.
        /// </summary>
        public const string Status = "Status";

        /// <summary>
        /// The BrowseName for the System1 component.
        /// </summary>
        public const string System1 = "Tank 1";

        /// <summary>
        /// The BrowseName for the ValveType component.
        /// </summary>
        public const string ValveType = "ValveType";

        /// <summary>
        /// The BrowseName for the Volt component.
        /// </summary>
        public const string Volt = "Volt";

        /// <summary>
        /// The BrowseName for the VoltageCommand component.
        /// </summary>
        public const string VoltageCommand = "VoltageCommand";

        /// <summary>
        /// The BrowseName for the VoltStatus component.
        /// </summary>
        public const string VoltStatus = "VoltStatus";

        /// <summary>
        /// The BrowseName for the Yellow1 component.
        /// </summary>
        public const string Yellow1 = "Yellow1";

        /// <summary>
        /// The BrowseName for the Yellow1Count component.
        /// </summary>
        public const string Yellow1Count = "Yellow1Count";

        /// <summary>
        /// The BrowseName for the Yellow2 component.
        /// </summary>
        public const string Yellow2 = "Yellow2";

        /// <summary>
        /// The BrowseName for the Yellow2Count component.
        /// </summary>
        public const string Yellow2Count = "Yellow2Count";

        /// <summary>
        /// The BrowseName for the Yellow3 component.
        /// </summary>
        public const string Yellow3 = "Yellow3";

        /// <summary>
        /// The BrowseName for the Yellow3Count component.
        /// </summary>
        public const string Yellow3Count = "Yellow3Count";

        /// <summary>
        /// The BrowseName for the Yellow4 component.
        /// </summary>
        public const string Yellow4 = "Yellow4";

        /// <summary>
        /// The BrowseName for the Yellow4Count component.
        /// </summary>
        public const string Yellow4Count = "Yellow4Count";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the ThesisServer namespace (.NET code namespace is 'ThesisServer').
        /// </summary>
        public const string ThesisServer = "http://opcfoundation.org/ThesisServer";
    }
    #endregion
}
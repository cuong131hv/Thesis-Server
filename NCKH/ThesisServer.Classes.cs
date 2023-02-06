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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace ThesisServer
{
    #region GenericControllerState Class
#if (!OPCUA_EXCLUDE_GenericControllerState)
    /// <summary>
    /// Stores an instance of the GenericControllerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericControllerState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericControllerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.GenericControllerType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAd" +
           "AAAAR2VuZXJpY0NvbnRyb2xsZXJUeXBlSW5zdGFuY2UBAZk6AQGZOpk6AAD/////BAAAADVgiQoCAAAA" +
           "AQAIAAAAU2V0UG9pbnQBAZo6AwAAAAAQAAAAU2V0UG9pbnQ6IERvdWJsZQAuAESaOgAAAAv/////AwP/" +
           "////AAAAADVgiQoCAAAAAQACAAAAS3ABAZs6AwAAAAAKAAAAS3A6IERvdWJsZQAuAESbOgAAAAv/////" +
           "AwP/////AAAAADVgiQoCAAAAAQACAAAAS2kBAZw6AwAAAAAKAAAAS2k6IERvdWJsZQAuAEScOgAAAAv/" +
           "////AwP/////AAAAADVgiQoCAAAAAQACAAAAS2QBAZ06AwAAAAAKAAAAS2Q6IERvdWJsZQAuAESdOgAA" +
           "AAv/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<double> SetPoint
        {
            get
            {
                return m_setPoint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setPoint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setPoint = value;
            }
        }

        /// <remarks />
        public PropertyState<double> Kp
        {
            get
            {
                return m_kp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_kp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_kp = value;
            }
        }

        /// <remarks />
        public PropertyState<double> Ki
        {
            get
            {
                return m_ki;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ki, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ki = value;
            }
        }

        /// <remarks />
        public PropertyState<double> Kd
        {
            get
            {
                return m_kd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_kd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_kd = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_setPoint != null)
            {
                children.Add(m_setPoint);
            }

            if (m_kp != null)
            {
                children.Add(m_kp);
            }

            if (m_ki != null)
            {
                children.Add(m_ki);
            }

            if (m_kd != null)
            {
                children.Add(m_kd);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.SetPoint:
                {
                    if (createOrReplace)
                    {
                        if (SetPoint == null)
                        {
                            if (replacement == null)
                            {
                                SetPoint = new PropertyState<double>(this);
                            }
                            else
                            {
                                SetPoint = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = SetPoint;
                    break;
                }

                case ThesisServer.BrowseNames.Kp:
                {
                    if (createOrReplace)
                    {
                        if (Kp == null)
                        {
                            if (replacement == null)
                            {
                                Kp = new PropertyState<double>(this);
                            }
                            else
                            {
                                Kp = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Kp;
                    break;
                }

                case ThesisServer.BrowseNames.Ki:
                {
                    if (createOrReplace)
                    {
                        if (Ki == null)
                        {
                            if (replacement == null)
                            {
                                Ki = new PropertyState<double>(this);
                            }
                            else
                            {
                                Ki = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Ki;
                    break;
                }

                case ThesisServer.BrowseNames.Kd:
                {
                    if (createOrReplace)
                    {
                        if (Kd == null)
                        {
                            if (replacement == null)
                            {
                                Kd = new PropertyState<double>(this);
                            }
                            else
                            {
                                Kd = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Kd;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<double> m_setPoint;
        private PropertyState<double> m_kp;
        private PropertyState<double> m_ki;
        private PropertyState<double> m_kd;
        #endregion
    }
    #endif
    #endregion

    #region AnalogInputType1State Class
    #if (!OPCUA_EXCLUDE_AnalogInputType1State)
    /// <summary>
    /// Stores an instance of the AnalogInputType1 ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogInputType1State : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogInputType1State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.AnalogInputType1, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAY" +
           "AAAAQW5hbG9nSW5wdXRUeXBlMUluc3RhbmNlAQGeOgEBnjqeOgAA/////woAAAA1YIkKAgAAAAEABgAA" +
           "AE91dHB1dAEBnzoDAAAAAA4AAABPdXRwdXQ6IERvdWJsZQAvAD+fOgAAAAv/////AwP/////AAAAADVg" +
           "iQoCAAAAAQAGAAAAQW1wZXJlAQGgOgMAAAAADgAAAEFtcGVyZTogRG91YmxlAC8AP6A6AAAAC/////8D" +
           "A/////8AAAAANWCJCgIAAAABAAwAAABBbXBlcmVTdGF0dXMBAaE6AwAAAAAVAAAAQW1wZXJlIHN0YXR1" +
           "czogc3RyaW5nAC8AP6E6AAAADP////8DA/////8AAAAANWCJCgIAAAABAAQAAABWb2x0AQGiOgMAAAAA" +
           "DAAAAFZvbHQ6IERvdWJsZQAvAD+iOgAAAAv/////AwP/////AAAAADVgiQoCAAAAAQAKAAAAVm9sdFN0" +
           "YXR1cwEBozoDAAAAABIAAABWb2x0U3RhdHVzOiBzdHJpbmcALwA/ozoAAAAM/////wMD/////wAAAAA1" +
           "YIkKAgAAAAEACQAAAEZyZXF1ZW5jeQEBpDoDAAAAABQAAABGcmVxdWVuY3lfSHo6IERvdWJsZQAvAD+k" +
           "OgAAAAv/////AwP/////AAAAADVgiQoCAAAAAQAFAAAAUG93ZXIBAaU6AwAAAAANAAAAUG93ZXI6IERv" +
           "dWJsZQAvAD+lOgAAAAv/////AwP/////AAAAADVgiQoCAAAAAQALAAAAUG93ZXJTdGF0dXMBAaY6AwAA" +
           "AAATAAAAUG93ZXJTdGF0dXM6IHN0cmluZwAvAD+mOgAAAAz/////AwP/////AAAAADVgiQoCAAAAAQAL" +
           "AAAAUG93ZXJGYWN0b3IBAac6AwAAAAATAAAAUG93ZXJGYWN0b3I6IERvdWJsZQAvAD+nOgAAAAv/////" +
           "AwP/////AAAAADVgiQoCAAAAAQAGAAAAU3RhdHVzAQGoOgMAAAAADwAAAFN0YXR1czogQm9vbGVhbgAv" +
           "AD+oOgAAAAH/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Ampere
        {
            get
            {
                return m_ampere;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ampere, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ampere = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> AmpereStatus
        {
            get
            {
                return m_ampereStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ampereStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ampereStatus = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Volt
        {
            get
            {
                return m_volt;
            }

            set
            {
                if (!Object.ReferenceEquals(m_volt, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_volt = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> VoltStatus
        {
            get
            {
                return m_voltStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_voltStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_voltStatus = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Frequency
        {
            get
            {
                return m_frequency;
            }

            set
            {
                if (!Object.ReferenceEquals(m_frequency, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_frequency = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Power
        {
            get
            {
                return m_power;
            }

            set
            {
                if (!Object.ReferenceEquals(m_power, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_power = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> PowerStatus
        {
            get
            {
                return m_powerStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_powerStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_powerStatus = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> PowerFactor
        {
            get
            {
                return m_powerFactor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_powerFactor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_powerFactor = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_output != null)
            {
                children.Add(m_output);
            }

            if (m_ampere != null)
            {
                children.Add(m_ampere);
            }

            if (m_ampereStatus != null)
            {
                children.Add(m_ampereStatus);
            }

            if (m_volt != null)
            {
                children.Add(m_volt);
            }

            if (m_voltStatus != null)
            {
                children.Add(m_voltStatus);
            }

            if (m_frequency != null)
            {
                children.Add(m_frequency);
            }

            if (m_power != null)
            {
                children.Add(m_power);
            }

            if (m_powerStatus != null)
            {
                children.Add(m_powerStatus);
            }

            if (m_powerFactor != null)
            {
                children.Add(m_powerFactor);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Output = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }

                case ThesisServer.BrowseNames.Ampere:
                {
                    if (createOrReplace)
                    {
                        if (Ampere == null)
                        {
                            if (replacement == null)
                            {
                                Ampere = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Ampere = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Ampere;
                    break;
                }

                case ThesisServer.BrowseNames.AmpereStatus:
                {
                    if (createOrReplace)
                    {
                        if (AmpereStatus == null)
                        {
                            if (replacement == null)
                            {
                                AmpereStatus = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                AmpereStatus = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = AmpereStatus;
                    break;
                }

                case ThesisServer.BrowseNames.Volt:
                {
                    if (createOrReplace)
                    {
                        if (Volt == null)
                        {
                            if (replacement == null)
                            {
                                Volt = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Volt = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Volt;
                    break;
                }

                case ThesisServer.BrowseNames.VoltStatus:
                {
                    if (createOrReplace)
                    {
                        if (VoltStatus == null)
                        {
                            if (replacement == null)
                            {
                                VoltStatus = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                VoltStatus = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = VoltStatus;
                    break;
                }

                case ThesisServer.BrowseNames.Frequency:
                {
                    if (createOrReplace)
                    {
                        if (Frequency == null)
                        {
                            if (replacement == null)
                            {
                                Frequency = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Frequency = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Frequency;
                    break;
                }

                case ThesisServer.BrowseNames.Power:
                {
                    if (createOrReplace)
                    {
                        if (Power == null)
                        {
                            if (replacement == null)
                            {
                                Power = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Power = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Power;
                    break;
                }

                case ThesisServer.BrowseNames.PowerStatus:
                {
                    if (createOrReplace)
                    {
                        if (PowerStatus == null)
                        {
                            if (replacement == null)
                            {
                                PowerStatus = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                PowerStatus = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = PowerStatus;
                    break;
                }

                case ThesisServer.BrowseNames.PowerFactor:
                {
                    if (createOrReplace)
                    {
                        if (PowerFactor == null)
                        {
                            if (replacement == null)
                            {
                                PowerFactor = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                PowerFactor = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = PowerFactor;
                    break;
                }

                case ThesisServer.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Status = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_output;
        private BaseDataVariableState<double> m_ampere;
        private BaseDataVariableState<string> m_ampereStatus;
        private BaseDataVariableState<double> m_volt;
        private BaseDataVariableState<string> m_voltStatus;
        private BaseDataVariableState<double> m_frequency;
        private BaseDataVariableState<double> m_power;
        private BaseDataVariableState<string> m_powerStatus;
        private BaseDataVariableState<double> m_powerFactor;
        private BaseDataVariableState<bool> m_status;
        #endregion
    }
    #endif
    #endregion

    #region AnalogInputType2State Class
    #if (!OPCUA_EXCLUDE_AnalogInputType2State)
    /// <summary>
    /// Stores an instance of the AnalogInputType2 ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogInputType2State : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogInputType2State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.AnalogInputType2, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAY" +
           "AAAAQW5hbG9nSW5wdXRUeXBlMkluc3RhbmNlAQGpOgEBqTqpOgAA/////wUAAAA1YIkKAgAAAAEAEAAA" +
           "AEZyZXF1ZW5jeUNvbW1hbmQBAao6AwAAAAAOAAAAU3RhdHVzOiBEb3VibGUALwA/qjoAAAAF/////wMD" +
           "/////wAAAAA1YIkKAgAAAAEADwAAAEZyZXF1ZW5jeU91dHB1dAEBqzoDAAAAAA4AAABTdGF0dXM6IERv" +
           "dWJsZQAvAD+rOgAAAAX/////AwP/////AAAAADVgiQoCAAAAAQANAAAAQ3VycmVudE91dHB1dAEBrDoD" +
           "AAAAAA4AAABTdGF0dXM6IERvdWJsZQAvAD+sOgAAAAX/////AwP/////AAAAADVgiQoCAAAAAQAOAAAA" +
           "Vm9sdGFnZUNvbW1hbmQBAa06AwAAAAAOAAAAU3RhdHVzOiBEb3VibGUALwA/rToAAAAF/////wMD////" +
           "/wAAAAA1YIkKAgAAAAEADAAAAERDQnVzVm9sdGFnZQEBrjoDAAAAAA4AAABTdGF0dXM6IERvdWJsZQAv" +
           "AD+uOgAAAAX/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<ushort> FrequencyCommand
        {
            get
            {
                return m_frequencyCommand;
            }

            set
            {
                if (!Object.ReferenceEquals(m_frequencyCommand, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_frequencyCommand = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> FrequencyOutput
        {
            get
            {
                return m_frequencyOutput;
            }

            set
            {
                if (!Object.ReferenceEquals(m_frequencyOutput, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_frequencyOutput = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> CurrentOutput
        {
            get
            {
                return m_currentOutput;
            }

            set
            {
                if (!Object.ReferenceEquals(m_currentOutput, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_currentOutput = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> VoltageCommand
        {
            get
            {
                return m_voltageCommand;
            }

            set
            {
                if (!Object.ReferenceEquals(m_voltageCommand, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_voltageCommand = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> DCBusVoltage
        {
            get
            {
                return m_dCBusVoltage;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dCBusVoltage, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dCBusVoltage = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_frequencyCommand != null)
            {
                children.Add(m_frequencyCommand);
            }

            if (m_frequencyOutput != null)
            {
                children.Add(m_frequencyOutput);
            }

            if (m_currentOutput != null)
            {
                children.Add(m_currentOutput);
            }

            if (m_voltageCommand != null)
            {
                children.Add(m_voltageCommand);
            }

            if (m_dCBusVoltage != null)
            {
                children.Add(m_dCBusVoltage);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.FrequencyCommand:
                {
                    if (createOrReplace)
                    {
                        if (FrequencyCommand == null)
                        {
                            if (replacement == null)
                            {
                                FrequencyCommand = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                FrequencyCommand = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = FrequencyCommand;
                    break;
                }

                case ThesisServer.BrowseNames.FrequencyOutput:
                {
                    if (createOrReplace)
                    {
                        if (FrequencyOutput == null)
                        {
                            if (replacement == null)
                            {
                                FrequencyOutput = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                FrequencyOutput = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = FrequencyOutput;
                    break;
                }

                case ThesisServer.BrowseNames.CurrentOutput:
                {
                    if (createOrReplace)
                    {
                        if (CurrentOutput == null)
                        {
                            if (replacement == null)
                            {
                                CurrentOutput = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                CurrentOutput = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = CurrentOutput;
                    break;
                }

                case ThesisServer.BrowseNames.VoltageCommand:
                {
                    if (createOrReplace)
                    {
                        if (VoltageCommand == null)
                        {
                            if (replacement == null)
                            {
                                VoltageCommand = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                VoltageCommand = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = VoltageCommand;
                    break;
                }

                case ThesisServer.BrowseNames.DCBusVoltage:
                {
                    if (createOrReplace)
                    {
                        if (DCBusVoltage == null)
                        {
                            if (replacement == null)
                            {
                                DCBusVoltage = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                DCBusVoltage = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = DCBusVoltage;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<ushort> m_frequencyCommand;
        private BaseDataVariableState<ushort> m_frequencyOutput;
        private BaseDataVariableState<ushort> m_currentOutput;
        private BaseDataVariableState<ushort> m_voltageCommand;
        private BaseDataVariableState<ushort> m_dCBusVoltage;
        #endregion
    }
    #endif
    #endregion

    #region AnalogInputType3State Class
    #if (!OPCUA_EXCLUDE_AnalogInputType3State)
    /// <summary>
    /// Stores an instance of the AnalogInputType3 ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogInputType3State : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogInputType3State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.AnalogInputType3, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAY" +
           "AAAAQW5hbG9nSW5wdXRUeXBlM0luc3RhbmNlAQGvOgEBrzqvOgAA/////wwAAAA1YIkKAgAAAAEACwAA" +
           "AEdyZWVuMUNvdW50AQGwOgMAAAAADgAAAFN0YXR1czogRG91YmxlAC8AP7A6AAAABf////8DA/////8A" +
           "AAAANWCJCgIAAAABAAwAAABZZWxsb3cxQ291bnQBAbE6AwAAAAAOAAAAU3RhdHVzOiBEb3VibGUALwA/" +
           "sToAAAAF/////wMD/////wAAAAA1YIkKAgAAAAEACQAAAFJlZDFDb3VudAEBsjoDAAAAAA4AAABTdGF0" +
           "dXM6IERvdWJsZQAvAD+yOgAAAAX/////AwP/////AAAAADVgiQoCAAAAAQALAAAAR3JlZW4yQ291bnQB" +
           "AbM6AwAAAAAOAAAAU3RhdHVzOiBEb3VibGUALwA/szoAAAAF/////wMD/////wAAAAA1YIkKAgAAAAEA" +
           "DAAAAFllbGxvdzJDb3VudAEBtDoDAAAAAA4AAABTdGF0dXM6IERvdWJsZQAvAD+0OgAAAAX/////AwP/" +
           "////AAAAADVgiQoCAAAAAQAJAAAAUmVkMkNvdW50AQG1OgMAAAAADgAAAFN0YXR1czogRG91YmxlAC8A" +
           "P7U6AAAABf////8DA/////8AAAAANWCJCgIAAAABAAsAAABHcmVlbjNDb3VudAEBtjoDAAAAAA4AAABT" +
           "dGF0dXM6IERvdWJsZQAvAD+2OgAAAAX/////AwP/////AAAAADVgiQoCAAAAAQAMAAAAWWVsbG93M0Nv" +
           "dW50AQG3OgMAAAAADgAAAFN0YXR1czogRG91YmxlAC8AP7c6AAAABf////8DA/////8AAAAANWCJCgIA" +
           "AAABAAkAAABSZWQzQ291bnQBAbg6AwAAAAAOAAAAU3RhdHVzOiBEb3VibGUALwA/uDoAAAAF/////wMD" +
           "/////wAAAAA1YIkKAgAAAAEACwAAAEdyZWVuNENvdW50AQG5OgMAAAAADgAAAFN0YXR1czogRG91Ymxl" +
           "AC8AP7k6AAAABf////8DA/////8AAAAANWCJCgIAAAABAAwAAABZZWxsb3c0Q291bnQBAbo6AwAAAAAO" +
           "AAAAU3RhdHVzOiBEb3VibGUALwA/ujoAAAAF/////wMD/////wAAAAA1YIkKAgAAAAEACQAAAFJlZDRD" +
           "b3VudAEBuzoDAAAAAA4AAABTdGF0dXM6IERvdWJsZQAvAD+7OgAAAAX/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<ushort> Green1Count
        {
            get
            {
                return m_green1Count;
            }

            set
            {
                if (!Object.ReferenceEquals(m_green1Count, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_green1Count = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> Yellow1Count
        {
            get
            {
                return m_yellow1Count;
            }

            set
            {
                if (!Object.ReferenceEquals(m_yellow1Count, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_yellow1Count = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> Red1Count
        {
            get
            {
                return m_red1Count;
            }

            set
            {
                if (!Object.ReferenceEquals(m_red1Count, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_red1Count = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> Green2Count
        {
            get
            {
                return m_green2Count;
            }

            set
            {
                if (!Object.ReferenceEquals(m_green2Count, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_green2Count = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> Yellow2Count
        {
            get
            {
                return m_yellow2Count;
            }

            set
            {
                if (!Object.ReferenceEquals(m_yellow2Count, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_yellow2Count = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> Red2Count
        {
            get
            {
                return m_red2Count;
            }

            set
            {
                if (!Object.ReferenceEquals(m_red2Count, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_red2Count = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> Green3Count
        {
            get
            {
                return m_green3Count;
            }

            set
            {
                if (!Object.ReferenceEquals(m_green3Count, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_green3Count = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> Yellow3Count
        {
            get
            {
                return m_yellow3Count;
            }

            set
            {
                if (!Object.ReferenceEquals(m_yellow3Count, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_yellow3Count = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> Red3Count
        {
            get
            {
                return m_red3Count;
            }

            set
            {
                if (!Object.ReferenceEquals(m_red3Count, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_red3Count = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> Green4Count
        {
            get
            {
                return m_green4Count;
            }

            set
            {
                if (!Object.ReferenceEquals(m_green4Count, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_green4Count = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> Yellow4Count
        {
            get
            {
                return m_yellow4Count;
            }

            set
            {
                if (!Object.ReferenceEquals(m_yellow4Count, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_yellow4Count = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> Red4Count
        {
            get
            {
                return m_red4Count;
            }

            set
            {
                if (!Object.ReferenceEquals(m_red4Count, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_red4Count = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_green1Count != null)
            {
                children.Add(m_green1Count);
            }

            if (m_yellow1Count != null)
            {
                children.Add(m_yellow1Count);
            }

            if (m_red1Count != null)
            {
                children.Add(m_red1Count);
            }

            if (m_green2Count != null)
            {
                children.Add(m_green2Count);
            }

            if (m_yellow2Count != null)
            {
                children.Add(m_yellow2Count);
            }

            if (m_red2Count != null)
            {
                children.Add(m_red2Count);
            }

            if (m_green3Count != null)
            {
                children.Add(m_green3Count);
            }

            if (m_yellow3Count != null)
            {
                children.Add(m_yellow3Count);
            }

            if (m_red3Count != null)
            {
                children.Add(m_red3Count);
            }

            if (m_green4Count != null)
            {
                children.Add(m_green4Count);
            }

            if (m_yellow4Count != null)
            {
                children.Add(m_yellow4Count);
            }

            if (m_red4Count != null)
            {
                children.Add(m_red4Count);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.Green1Count:
                {
                    if (createOrReplace)
                    {
                        if (Green1Count == null)
                        {
                            if (replacement == null)
                            {
                                Green1Count = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Green1Count = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Green1Count;
                    break;
                }

                case ThesisServer.BrowseNames.Yellow1Count:
                {
                    if (createOrReplace)
                    {
                        if (Yellow1Count == null)
                        {
                            if (replacement == null)
                            {
                                Yellow1Count = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Yellow1Count = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Yellow1Count;
                    break;
                }

                case ThesisServer.BrowseNames.Red1Count:
                {
                    if (createOrReplace)
                    {
                        if (Red1Count == null)
                        {
                            if (replacement == null)
                            {
                                Red1Count = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Red1Count = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Red1Count;
                    break;
                }

                case ThesisServer.BrowseNames.Green2Count:
                {
                    if (createOrReplace)
                    {
                        if (Green2Count == null)
                        {
                            if (replacement == null)
                            {
                                Green2Count = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Green2Count = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Green2Count;
                    break;
                }

                case ThesisServer.BrowseNames.Yellow2Count:
                {
                    if (createOrReplace)
                    {
                        if (Yellow2Count == null)
                        {
                            if (replacement == null)
                            {
                                Yellow2Count = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Yellow2Count = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Yellow2Count;
                    break;
                }

                case ThesisServer.BrowseNames.Red2Count:
                {
                    if (createOrReplace)
                    {
                        if (Red2Count == null)
                        {
                            if (replacement == null)
                            {
                                Red2Count = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Red2Count = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Red2Count;
                    break;
                }

                case ThesisServer.BrowseNames.Green3Count:
                {
                    if (createOrReplace)
                    {
                        if (Green3Count == null)
                        {
                            if (replacement == null)
                            {
                                Green3Count = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Green3Count = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Green3Count;
                    break;
                }

                case ThesisServer.BrowseNames.Yellow3Count:
                {
                    if (createOrReplace)
                    {
                        if (Yellow3Count == null)
                        {
                            if (replacement == null)
                            {
                                Yellow3Count = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Yellow3Count = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Yellow3Count;
                    break;
                }

                case ThesisServer.BrowseNames.Red3Count:
                {
                    if (createOrReplace)
                    {
                        if (Red3Count == null)
                        {
                            if (replacement == null)
                            {
                                Red3Count = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Red3Count = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Red3Count;
                    break;
                }

                case ThesisServer.BrowseNames.Green4Count:
                {
                    if (createOrReplace)
                    {
                        if (Green4Count == null)
                        {
                            if (replacement == null)
                            {
                                Green4Count = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Green4Count = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Green4Count;
                    break;
                }

                case ThesisServer.BrowseNames.Yellow4Count:
                {
                    if (createOrReplace)
                    {
                        if (Yellow4Count == null)
                        {
                            if (replacement == null)
                            {
                                Yellow4Count = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Yellow4Count = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Yellow4Count;
                    break;
                }

                case ThesisServer.BrowseNames.Red4Count:
                {
                    if (createOrReplace)
                    {
                        if (Red4Count == null)
                        {
                            if (replacement == null)
                            {
                                Red4Count = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Red4Count = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Red4Count;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<ushort> m_green1Count;
        private BaseDataVariableState<ushort> m_yellow1Count;
        private BaseDataVariableState<ushort> m_red1Count;
        private BaseDataVariableState<ushort> m_green2Count;
        private BaseDataVariableState<ushort> m_yellow2Count;
        private BaseDataVariableState<ushort> m_red2Count;
        private BaseDataVariableState<ushort> m_green3Count;
        private BaseDataVariableState<ushort> m_yellow3Count;
        private BaseDataVariableState<ushort> m_red3Count;
        private BaseDataVariableState<ushort> m_green4Count;
        private BaseDataVariableState<ushort> m_yellow4Count;
        private BaseDataVariableState<ushort> m_red4Count;
        #endregion
    }
    #endif
    #endregion

    #region AnalogOutputState Class
    #if (!OPCUA_EXCLUDE_AnalogOutputState)
    /// <summary>
    /// Stores an instance of the AnalogOutputType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogOutputState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogOutputState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.AnalogOutputType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAY" +
           "AAAAQW5hbG9nT3V0cHV0VHlwZUluc3RhbmNlAQG8OgEBvDq8OgAA/////wIAAAA1YIkKAgAAAAEADgAA" +
           "AEZyZXF1ZW5jeVdyaXRlAQG9OgMAAAAADQAAAElucHV0OiBEb3VibGUALwA/vToAAAAF/////wMD////" +
           "/wAAAAA1YIkKAgAAAAEADwAAAENvbnRyb2xSdW5Xcml0ZQEBvjoDAAAAAA0AAABJbnB1dDogRG91Ymxl" +
           "AC8AP746AAAABf////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<ushort> FrequencyWrite
        {
            get
            {
                return m_frequencyWrite;
            }

            set
            {
                if (!Object.ReferenceEquals(m_frequencyWrite, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_frequencyWrite = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> ControlRunWrite
        {
            get
            {
                return m_controlRunWrite;
            }

            set
            {
                if (!Object.ReferenceEquals(m_controlRunWrite, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_controlRunWrite = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_frequencyWrite != null)
            {
                children.Add(m_frequencyWrite);
            }

            if (m_controlRunWrite != null)
            {
                children.Add(m_controlRunWrite);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.FrequencyWrite:
                {
                    if (createOrReplace)
                    {
                        if (FrequencyWrite == null)
                        {
                            if (replacement == null)
                            {
                                FrequencyWrite = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                FrequencyWrite = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = FrequencyWrite;
                    break;
                }

                case ThesisServer.BrowseNames.ControlRunWrite:
                {
                    if (createOrReplace)
                    {
                        if (ControlRunWrite == null)
                        {
                            if (replacement == null)
                            {
                                ControlRunWrite = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                ControlRunWrite = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = ControlRunWrite;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<ushort> m_frequencyWrite;
        private BaseDataVariableState<ushort> m_controlRunWrite;
        #endregion
    }
    #endif
    #endregion

    #region DigitalState Class
    #if (!OPCUA_EXCLUDE_DigitalState)
    /// <summary>
    /// Stores an instance of the DigitalType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DigitalState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DigitalState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.DigitalType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAT" +
           "AAAARGlnaXRhbFR5cGVJbnN0YW5jZQEBvzoBAb86vzoAAP////8MAAAANWCJCgIAAAABAAYAAABHcmVl" +
           "bjEBAcA6AwAAAAAOAAAAVmFsdWU6IEJvb2xlYW4ALwA/wDoAAAAB/////wMD/////wAAAAA1YIkKAgAA" +
           "AAEABwAAAFllbGxvdzEBAcE6AwAAAAAOAAAAVmFsdWU6IEJvb2xlYW4ALwA/wToAAAAB/////wMD////" +
           "/wAAAAA1YIkKAgAAAAEABAAAAFJlZDEBAcI6AwAAAAAOAAAAVmFsdWU6IEJvb2xlYW4ALwA/wjoAAAAB" +
           "/////wMD/////wAAAAA1YIkKAgAAAAEABgAAAEdyZWVuMgEBwzoDAAAAAA4AAABWYWx1ZTogQm9vbGVh" +
           "bgAvAD/DOgAAAAH/////AwP/////AAAAADVgiQoCAAAAAQAHAAAAWWVsbG93MgEBxDoDAAAAAA4AAABW" +
           "YWx1ZTogQm9vbGVhbgAvAD/EOgAAAAH/////AwP/////AAAAADVgiQoCAAAAAQAEAAAAUmVkMgEBxToD" +
           "AAAAAA4AAABWYWx1ZTogQm9vbGVhbgAvAD/FOgAAAAH/////AwP/////AAAAADVgiQoCAAAAAQAGAAAA" +
           "R3JlZW4zAQHGOgMAAAAADgAAAFZhbHVlOiBCb29sZWFuAC8AP8Y6AAAAAf////8DA/////8AAAAANWCJ" +
           "CgIAAAABAAcAAABZZWxsb3czAQHHOgMAAAAADgAAAFZhbHVlOiBCb29sZWFuAC8AP8c6AAAAAf////8D" +
           "A/////8AAAAANWCJCgIAAAABAAQAAABSZWQzAQHIOgMAAAAADgAAAFZhbHVlOiBCb29sZWFuAC8AP8g6" +
           "AAAAAf////8DA/////8AAAAANWCJCgIAAAABAAYAAABHcmVlbjQBAck6AwAAAAAOAAAAVmFsdWU6IEJv" +
           "b2xlYW4ALwA/yToAAAAB/////wMD/////wAAAAA1YIkKAgAAAAEABwAAAFllbGxvdzQBAco6AwAAAAAO" +
           "AAAAVmFsdWU6IEJvb2xlYW4ALwA/yjoAAAAB/////wMD/////wAAAAA1YIkKAgAAAAEABAAAAFJlZDQB" +
           "Acs6AwAAAAAOAAAAVmFsdWU6IEJvb2xlYW4ALwA/yzoAAAAB/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> Green1
        {
            get
            {
                return m_green1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_green1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_green1 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Yellow1
        {
            get
            {
                return m_yellow1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_yellow1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_yellow1 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Red1
        {
            get
            {
                return m_red1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_red1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_red1 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Green2
        {
            get
            {
                return m_green2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_green2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_green2 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Yellow2
        {
            get
            {
                return m_yellow2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_yellow2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_yellow2 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Red2
        {
            get
            {
                return m_red2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_red2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_red2 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Green3
        {
            get
            {
                return m_green3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_green3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_green3 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Yellow3
        {
            get
            {
                return m_yellow3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_yellow3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_yellow3 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Red3
        {
            get
            {
                return m_red3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_red3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_red3 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Green4
        {
            get
            {
                return m_green4;
            }

            set
            {
                if (!Object.ReferenceEquals(m_green4, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_green4 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Yellow4
        {
            get
            {
                return m_yellow4;
            }

            set
            {
                if (!Object.ReferenceEquals(m_yellow4, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_yellow4 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Red4
        {
            get
            {
                return m_red4;
            }

            set
            {
                if (!Object.ReferenceEquals(m_red4, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_red4 = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_green1 != null)
            {
                children.Add(m_green1);
            }

            if (m_yellow1 != null)
            {
                children.Add(m_yellow1);
            }

            if (m_red1 != null)
            {
                children.Add(m_red1);
            }

            if (m_green2 != null)
            {
                children.Add(m_green2);
            }

            if (m_yellow2 != null)
            {
                children.Add(m_yellow2);
            }

            if (m_red2 != null)
            {
                children.Add(m_red2);
            }

            if (m_green3 != null)
            {
                children.Add(m_green3);
            }

            if (m_yellow3 != null)
            {
                children.Add(m_yellow3);
            }

            if (m_red3 != null)
            {
                children.Add(m_red3);
            }

            if (m_green4 != null)
            {
                children.Add(m_green4);
            }

            if (m_yellow4 != null)
            {
                children.Add(m_yellow4);
            }

            if (m_red4 != null)
            {
                children.Add(m_red4);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.Green1:
                {
                    if (createOrReplace)
                    {
                        if (Green1 == null)
                        {
                            if (replacement == null)
                            {
                                Green1 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Green1 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Green1;
                    break;
                }

                case ThesisServer.BrowseNames.Yellow1:
                {
                    if (createOrReplace)
                    {
                        if (Yellow1 == null)
                        {
                            if (replacement == null)
                            {
                                Yellow1 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Yellow1 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Yellow1;
                    break;
                }

                case ThesisServer.BrowseNames.Red1:
                {
                    if (createOrReplace)
                    {
                        if (Red1 == null)
                        {
                            if (replacement == null)
                            {
                                Red1 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Red1 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Red1;
                    break;
                }

                case ThesisServer.BrowseNames.Green2:
                {
                    if (createOrReplace)
                    {
                        if (Green2 == null)
                        {
                            if (replacement == null)
                            {
                                Green2 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Green2 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Green2;
                    break;
                }

                case ThesisServer.BrowseNames.Yellow2:
                {
                    if (createOrReplace)
                    {
                        if (Yellow2 == null)
                        {
                            if (replacement == null)
                            {
                                Yellow2 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Yellow2 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Yellow2;
                    break;
                }

                case ThesisServer.BrowseNames.Red2:
                {
                    if (createOrReplace)
                    {
                        if (Red2 == null)
                        {
                            if (replacement == null)
                            {
                                Red2 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Red2 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Red2;
                    break;
                }

                case ThesisServer.BrowseNames.Green3:
                {
                    if (createOrReplace)
                    {
                        if (Green3 == null)
                        {
                            if (replacement == null)
                            {
                                Green3 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Green3 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Green3;
                    break;
                }

                case ThesisServer.BrowseNames.Yellow3:
                {
                    if (createOrReplace)
                    {
                        if (Yellow3 == null)
                        {
                            if (replacement == null)
                            {
                                Yellow3 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Yellow3 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Yellow3;
                    break;
                }

                case ThesisServer.BrowseNames.Red3:
                {
                    if (createOrReplace)
                    {
                        if (Red3 == null)
                        {
                            if (replacement == null)
                            {
                                Red3 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Red3 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Red3;
                    break;
                }

                case ThesisServer.BrowseNames.Green4:
                {
                    if (createOrReplace)
                    {
                        if (Green4 == null)
                        {
                            if (replacement == null)
                            {
                                Green4 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Green4 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Green4;
                    break;
                }

                case ThesisServer.BrowseNames.Yellow4:
                {
                    if (createOrReplace)
                    {
                        if (Yellow4 == null)
                        {
                            if (replacement == null)
                            {
                                Yellow4 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Yellow4 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Yellow4;
                    break;
                }

                case ThesisServer.BrowseNames.Red4:
                {
                    if (createOrReplace)
                    {
                        if (Red4 == null)
                        {
                            if (replacement == null)
                            {
                                Red4 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Red4 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Red4;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_green1;
        private BaseDataVariableState<bool> m_yellow1;
        private BaseDataVariableState<bool> m_red1;
        private BaseDataVariableState<bool> m_green2;
        private BaseDataVariableState<bool> m_yellow2;
        private BaseDataVariableState<bool> m_red2;
        private BaseDataVariableState<bool> m_green3;
        private BaseDataVariableState<bool> m_yellow3;
        private BaseDataVariableState<bool> m_red3;
        private BaseDataVariableState<bool> m_green4;
        private BaseDataVariableState<bool> m_yellow4;
        private BaseDataVariableState<bool> m_red4;
        #endregion
    }
    #endif
    #endregion

    #region ValveState Class
    #if (!OPCUA_EXCLUDE_ValveState)
    /// <summary>
    /// Stores an instance of the ValveType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ValveState : AnalogOutputState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ValveState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.ValveType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAR" +
           "AAAAVmFsdmVUeXBlSW5zdGFuY2UBAcw6AQHMOsw6AAD/////AgAAADVgiQoCAAAAAQAOAAAARnJlcXVl" +
           "bmN5V3JpdGUBAc06AwAAAAANAAAASW5wdXQ6IERvdWJsZQAvAD/NOgAAAAX/////AwP/////AAAAADVg" +
           "iQoCAAAAAQAPAAAAQ29udHJvbFJ1bldyaXRlAQHOOgMAAAAADQAAAElucHV0OiBEb3VibGUALwA/zjoA" +
           "AAAF/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AnalogSensorType1State Class
    #if (!OPCUA_EXCLUDE_AnalogSensorType1State)
    /// <summary>
    /// Stores an instance of the AnalogSensorType1 ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogSensorType1State : AnalogInputType1State
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogSensorType1State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.AnalogSensorType1, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAZ" +
           "AAAAQW5hbG9nU2Vuc29yVHlwZTFJbnN0YW5jZQEBzzoBAc86zzoAAP////8KAAAANWCJCgIAAAABAAYA" +
           "AABPdXRwdXQBAdA6AwAAAAAOAAAAT3V0cHV0OiBEb3VibGUALwA/0DoAAAAL/////wMD/////wAAAAA1" +
           "YIkKAgAAAAEABgAAAEFtcGVyZQEB0ToDAAAAAA4AAABBbXBlcmU6IERvdWJsZQAvAD/ROgAAAAv/////" +
           "AwP/////AAAAADVgiQoCAAAAAQAMAAAAQW1wZXJlU3RhdHVzAQHSOgMAAAAAFQAAAEFtcGVyZSBzdGF0" +
           "dXM6IHN0cmluZwAvAD/SOgAAAAz/////AwP/////AAAAADVgiQoCAAAAAQAEAAAAVm9sdAEB0zoDAAAA" +
           "AAwAAABWb2x0OiBEb3VibGUALwA/0zoAAAAL/////wMD/////wAAAAA1YIkKAgAAAAEACgAAAFZvbHRT" +
           "dGF0dXMBAdQ6AwAAAAASAAAAVm9sdFN0YXR1czogc3RyaW5nAC8AP9Q6AAAADP////8DA/////8AAAAA" +
           "NWCJCgIAAAABAAkAAABGcmVxdWVuY3kBAdU6AwAAAAAUAAAARnJlcXVlbmN5X0h6OiBEb3VibGUALwA/" +
           "1ToAAAAL/////wMD/////wAAAAA1YIkKAgAAAAEABQAAAFBvd2VyAQHWOgMAAAAADQAAAFBvd2VyOiBE" +
           "b3VibGUALwA/1joAAAAL/////wMD/////wAAAAA1YIkKAgAAAAEACwAAAFBvd2VyU3RhdHVzAQHXOgMA" +
           "AAAAEwAAAFBvd2VyU3RhdHVzOiBzdHJpbmcALwA/1zoAAAAM/////wMD/////wAAAAA1YIkKAgAAAAEA" +
           "CwAAAFBvd2VyRmFjdG9yAQHYOgMAAAAAEwAAAFBvd2VyRmFjdG9yOiBEb3VibGUALwA/2DoAAAAL////" +
           "/wMD/////wAAAAA1YIkKAgAAAAEABgAAAFN0YXR1cwEB2ToDAAAAAA8AAABTdGF0dXM6IEJvb2xlYW4A" +
           "LwA/2ToAAAAB/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AnalogSensorType2State Class
    #if (!OPCUA_EXCLUDE_AnalogSensorType2State)
    /// <summary>
    /// Stores an instance of the AnalogSensorType2 ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogSensorType2State : AnalogInputType2State
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogSensorType2State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.AnalogSensorType2, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAZ" +
           "AAAAQW5hbG9nU2Vuc29yVHlwZTJJbnN0YW5jZQEB2joBAdo62joAAP////8FAAAANWCJCgIAAAABABAA" +
           "AABGcmVxdWVuY3lDb21tYW5kAQHbOgMAAAAADgAAAFN0YXR1czogRG91YmxlAC8AP9s6AAAABf////8D" +
           "A/////8AAAAANWCJCgIAAAABAA8AAABGcmVxdWVuY3lPdXRwdXQBAdw6AwAAAAAOAAAAU3RhdHVzOiBE" +
           "b3VibGUALwA/3DoAAAAF/////wMD/////wAAAAA1YIkKAgAAAAEADQAAAEN1cnJlbnRPdXRwdXQBAd06" +
           "AwAAAAAOAAAAU3RhdHVzOiBEb3VibGUALwA/3ToAAAAF/////wMD/////wAAAAA1YIkKAgAAAAEADgAA" +
           "AFZvbHRhZ2VDb21tYW5kAQHeOgMAAAAADgAAAFN0YXR1czogRG91YmxlAC8AP946AAAABf////8DA///" +
           "//8AAAAANWCJCgIAAAABAAwAAABEQ0J1c1ZvbHRhZ2UBAd86AwAAAAAOAAAAU3RhdHVzOiBEb3VibGUA" +
           "LwA/3zoAAAAF/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AnalogSensorType3State Class
    #if (!OPCUA_EXCLUDE_AnalogSensorType3State)
    /// <summary>
    /// Stores an instance of the AnalogSensorType3 ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogSensorType3State : AnalogInputType3State
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogSensorType3State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.AnalogSensorType3, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAZ" +
           "AAAAQW5hbG9nU2Vuc29yVHlwZTNJbnN0YW5jZQEB4DoBAeA64DoAAP////8MAAAANWCJCgIAAAABAAsA" +
           "AABHcmVlbjFDb3VudAEB4ToDAAAAAA4AAABTdGF0dXM6IERvdWJsZQAvAD/hOgAAAAX/////AwP/////" +
           "AAAAADVgiQoCAAAAAQAMAAAAWWVsbG93MUNvdW50AQHiOgMAAAAADgAAAFN0YXR1czogRG91YmxlAC8A" +
           "P+I6AAAABf////8DA/////8AAAAANWCJCgIAAAABAAkAAABSZWQxQ291bnQBAeM6AwAAAAAOAAAAU3Rh" +
           "dHVzOiBEb3VibGUALwA/4zoAAAAF/////wMD/////wAAAAA1YIkKAgAAAAEACwAAAEdyZWVuMkNvdW50" +
           "AQHkOgMAAAAADgAAAFN0YXR1czogRG91YmxlAC8AP+Q6AAAABf////8DA/////8AAAAANWCJCgIAAAAB" +
           "AAwAAABZZWxsb3cyQ291bnQBAeU6AwAAAAAOAAAAU3RhdHVzOiBEb3VibGUALwA/5ToAAAAF/////wMD" +
           "/////wAAAAA1YIkKAgAAAAEACQAAAFJlZDJDb3VudAEB5joDAAAAAA4AAABTdGF0dXM6IERvdWJsZQAv" +
           "AD/mOgAAAAX/////AwP/////AAAAADVgiQoCAAAAAQALAAAAR3JlZW4zQ291bnQBAec6AwAAAAAOAAAA" +
           "U3RhdHVzOiBEb3VibGUALwA/5zoAAAAF/////wMD/////wAAAAA1YIkKAgAAAAEADAAAAFllbGxvdzND" +
           "b3VudAEB6DoDAAAAAA4AAABTdGF0dXM6IERvdWJsZQAvAD/oOgAAAAX/////AwP/////AAAAADVgiQoC" +
           "AAAAAQAJAAAAUmVkM0NvdW50AQHpOgMAAAAADgAAAFN0YXR1czogRG91YmxlAC8AP+k6AAAABf////8D" +
           "A/////8AAAAANWCJCgIAAAABAAsAAABHcmVlbjRDb3VudAEB6joDAAAAAA4AAABTdGF0dXM6IERvdWJs" +
           "ZQAvAD/qOgAAAAX/////AwP/////AAAAADVgiQoCAAAAAQAMAAAAWWVsbG93NENvdW50AQHrOgMAAAAA" +
           "DgAAAFN0YXR1czogRG91YmxlAC8AP+s6AAAABf////8DA/////8AAAAANWCJCgIAAAABAAkAAABSZWQ0" +
           "Q291bnQBAew6AwAAAAAOAAAAU3RhdHVzOiBEb3VibGUALwA/7DoAAAAF/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ButtonState Class
    #if (!OPCUA_EXCLUDE_ButtonState)
    /// <summary>
    /// Stores an instance of the ButtonType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ButtonState : DigitalState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ButtonState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.ButtonType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAS" +
           "AAAAQnV0dG9uVHlwZUluc3RhbmNlAQHtOgEB7TrtOgAA/////wwAAAA1YIkKAgAAAAEABgAAAEdyZWVu" +
           "MQEB7joDAAAAAA4AAABWYWx1ZTogQm9vbGVhbgAvAD/uOgAAAAH/////AwP/////AAAAADVgiQoCAAAA" +
           "AQAHAAAAWWVsbG93MQEB7zoDAAAAAA4AAABWYWx1ZTogQm9vbGVhbgAvAD/vOgAAAAH/////AwP/////" +
           "AAAAADVgiQoCAAAAAQAEAAAAUmVkMQEB8DoDAAAAAA4AAABWYWx1ZTogQm9vbGVhbgAvAD/wOgAAAAH/" +
           "////AwP/////AAAAADVgiQoCAAAAAQAGAAAAR3JlZW4yAQHxOgMAAAAADgAAAFZhbHVlOiBCb29sZWFu" +
           "AC8AP/E6AAAAAf////8DA/////8AAAAANWCJCgIAAAABAAcAAABZZWxsb3cyAQHyOgMAAAAADgAAAFZh" +
           "bHVlOiBCb29sZWFuAC8AP/I6AAAAAf////8DA/////8AAAAANWCJCgIAAAABAAQAAABSZWQyAQHzOgMA" +
           "AAAADgAAAFZhbHVlOiBCb29sZWFuAC8AP/M6AAAAAf////8DA/////8AAAAANWCJCgIAAAABAAYAAABH" +
           "cmVlbjMBAfQ6AwAAAAAOAAAAVmFsdWU6IEJvb2xlYW4ALwA/9DoAAAAB/////wMD/////wAAAAA1YIkK" +
           "AgAAAAEABwAAAFllbGxvdzMBAfU6AwAAAAAOAAAAVmFsdWU6IEJvb2xlYW4ALwA/9ToAAAAB/////wMD" +
           "/////wAAAAA1YIkKAgAAAAEABAAAAFJlZDMBAfY6AwAAAAAOAAAAVmFsdWU6IEJvb2xlYW4ALwA/9joA" +
           "AAAB/////wMD/////wAAAAA1YIkKAgAAAAEABgAAAEdyZWVuNAEB9zoDAAAAAA4AAABWYWx1ZTogQm9v" +
           "bGVhbgAvAD/3OgAAAAH/////AwP/////AAAAADVgiQoCAAAAAQAHAAAAWWVsbG93NAEB+DoDAAAAAA4A" +
           "AABWYWx1ZTogQm9vbGVhbgAvAD/4OgAAAAH/////AwP/////AAAAADVgiQoCAAAAAQAEAAAAUmVkNAEB" +
           "+ToDAAAAAA4AAABWYWx1ZTogQm9vbGVhbgAvAD/5OgAAAAH/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}
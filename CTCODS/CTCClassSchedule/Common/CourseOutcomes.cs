﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5448
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseOutcomesWCF
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/CourseOutcomesWCF")]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private bool BoolValueField;

        private string StringValueField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue
        {
            get
            {
                return this.BoolValueField;
            }
            set
            {
                this.BoolValueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue
        {
            get
            {
                return this.StringValueField;
            }
            set
            {
                this.StringValueField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IService1")]
public interface IService1
{

    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
    string GetData(int value);

    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
    CourseOutcomesWCF.CompositeType GetDataUsingDataContract(CourseOutcomesWCF.CompositeType composite);

    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCourseOutcome", ReplyAction="http://tempuri.org/IService1/GetCourseOutcomeResponse")]
    string GetCourseOutcome(string CourseID);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IService1Channel : IService1, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class Service1Client : System.ServiceModel.ClientBase<IService1>, IService1
{

    public Service1Client()
    {
    }

    public Service1Client(string endpointConfigurationName) :
            base(endpointConfigurationName)
    {
    }

    public Service1Client(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    public string GetData(int value)
    {
        return base.Channel.GetData(value);
    }

    public CourseOutcomesWCF.CompositeType GetDataUsingDataContract(CourseOutcomesWCF.CompositeType composite)
    {
        return base.Channel.GetDataUsingDataContract(composite);
    }

    public string GetCourseOutcome(string CourseID)
    {
        return base.Channel.GetCourseOutcome(CourseID);
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IC1ReportsSchedulerWcf", CallbackContract=typeof(IC1ReportsSchedulerWcfCallback))]
public interface IC1ReportsSchedulerWcf
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IC1ReportsSchedulerWcf/Connect", ReplyAction="http://tempuri.org/IC1ReportsSchedulerWcf/ConnectResponse")]
    void Connect();
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/Disconnect")]
    void Disconnect(string reason);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IC1ReportsSchedulerWcf/Ping", ReplyAction="http://tempuri.org/IC1ReportsSchedulerWcf/PingResponse")]
    bool Ping();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IC1ReportsSchedulerWcf/GetAboutString", ReplyAction="http://tempuri.org/IC1ReportsSchedulerWcf/GetAboutStringResponse")]
    string GetAboutString();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IC1ReportsSchedulerWcf/GetTaskCount", ReplyAction="http://tempuri.org/IC1ReportsSchedulerWcf/GetTaskCountResponse")]
    int GetTaskCount();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IC1ReportsSchedulerWcf/GetTaskId", ReplyAction="http://tempuri.org/IC1ReportsSchedulerWcf/GetTaskIdResponse")]
    long GetTaskId(int taskIndex);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IC1ReportsSchedulerWcf/GetTaskXml", ReplyAction="http://tempuri.org/IC1ReportsSchedulerWcf/GetTaskXmlResponse")]
    string GetTaskXml(long taskId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IC1ReportsSchedulerWcf/GetActionCount", ReplyAction="http://tempuri.org/IC1ReportsSchedulerWcf/GetActionCountResponse")]
    int GetActionCount(long taskId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IC1ReportsSchedulerWcf/GetActionId", ReplyAction="http://tempuri.org/IC1ReportsSchedulerWcf/GetActionIdResponse")]
    long GetActionId(long taskId, int actionIndex);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IC1ReportsSchedulerWcf/GetActionXml", ReplyAction="http://tempuri.org/IC1ReportsSchedulerWcf/GetActionXmlResponse")]
    string GetActionXml(long taskId, long actionId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IC1ReportsSchedulerWcf/GetScheduleXml", ReplyAction="http://tempuri.org/IC1ReportsSchedulerWcf/GetScheduleXmlResponse")]
    string GetScheduleXml(long taskId);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/AddTask")]
    void AddTask();
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/RemoveTask")]
    void RemoveTask(long taskId);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/MoveTask")]
    void MoveTask(long taskId, bool down);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IC1ReportsSchedulerWcf/CheckTask", ReplyAction="http://tempuri.org/IC1ReportsSchedulerWcf/CheckTaskResponse")]
    bool CheckTask(long taskId, bool checkActions);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IC1ReportsSchedulerWcf/SerializeTaskListHolder", ReplyAction="http://tempuri.org/IC1ReportsSchedulerWcf/SerializeTaskListHolderResponse")]
    string SerializeTaskListHolder();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IC1ReportsSchedulerWcf/SerializeDocument", ReplyAction="http://tempuri.org/IC1ReportsSchedulerWcf/SerializeDocumentResponse")]
    string SerializeDocument(long taskId);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/AddAction")]
    void AddAction(long taskId);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/MoveAction")]
    void MoveAction(long taskId, long actionId, bool down);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/RemoveAction")]
    void RemoveAction(long taskId, long actionId);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/SetTaskProperty")]
    void SetTaskProperty(long taskId, string propertyName, string propertyValue);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/SetActionProperty")]
    void SetActionProperty(long taskId, long actionId, string propertyName, string propertyValue);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/SetScheduleProperty")]
    void SetScheduleProperty(long taskId, string propertyName, string propertyValue);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IC1ReportsSchedulerWcfCallback
{
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/TaskPropertyChanged")]
    void TaskPropertyChanged(long taskId, string taskXml, string propertyName);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/ActionPropertyChanged")]
    void ActionPropertyChanged(long taskId, long actionId, string actionXml, string propertyName);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/SchedulePropertyChanged")]
    void SchedulePropertyChanged(long taskId, string scheduleXml, string propertyName);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/TaskAdded")]
    void TaskAdded(int index, long taskId, string taskXml);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/TaskRemoved")]
    void TaskRemoved(long taskId);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/ActionAdded")]
    void ActionAdded(long taskId, int actionIndex, long actionId, string actionXml);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IC1ReportsSchedulerWcf/ActionRemoved")]
    void ActionRemoved(long taskId, long actionId);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IC1ReportsSchedulerWcfChannel : IC1ReportsSchedulerWcf, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class C1ReportsSchedulerWcfClient : System.ServiceModel.DuplexClientBase<IC1ReportsSchedulerWcf>, IC1ReportsSchedulerWcf
{
    
    public C1ReportsSchedulerWcfClient(System.ServiceModel.InstanceContext callbackInstance) : 
            base(callbackInstance)
    {
    }
    
    public C1ReportsSchedulerWcfClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
            base(callbackInstance, endpointConfigurationName)
    {
    }
    
    public C1ReportsSchedulerWcfClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
            base(callbackInstance, endpointConfigurationName, remoteAddress)
    {
    }
    
    public C1ReportsSchedulerWcfClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(callbackInstance, endpointConfigurationName, remoteAddress)
    {
    }
    
    public C1ReportsSchedulerWcfClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(callbackInstance, binding, remoteAddress)
    {
    }
    
    public void Connect()
    {
        base.Channel.Connect();
    }
    
    public void Disconnect(string reason)
    {
        base.Channel.Disconnect(reason);
    }
    
    public bool Ping()
    {
        return base.Channel.Ping();
    }
    
    public string GetAboutString()
    {
        return base.Channel.GetAboutString();
    }
    
    public int GetTaskCount()
    {
        return base.Channel.GetTaskCount();
    }
    
    public long GetTaskId(int taskIndex)
    {
        return base.Channel.GetTaskId(taskIndex);
    }
    
    public string GetTaskXml(long taskId)
    {
        return base.Channel.GetTaskXml(taskId);
    }
    
    public int GetActionCount(long taskId)
    {
        return base.Channel.GetActionCount(taskId);
    }
    
    public long GetActionId(long taskId, int actionIndex)
    {
        return base.Channel.GetActionId(taskId, actionIndex);
    }
    
    public string GetActionXml(long taskId, long actionId)
    {
        return base.Channel.GetActionXml(taskId, actionId);
    }
    
    public string GetScheduleXml(long taskId)
    {
        return base.Channel.GetScheduleXml(taskId);
    }
    
    public void AddTask()
    {
        base.Channel.AddTask();
    }
    
    public void RemoveTask(long taskId)
    {
        base.Channel.RemoveTask(taskId);
    }
    
    public void MoveTask(long taskId, bool down)
    {
        base.Channel.MoveTask(taskId, down);
    }
    
    public bool CheckTask(long taskId, bool checkActions)
    {
        return base.Channel.CheckTask(taskId, checkActions);
    }
    
    public string SerializeTaskListHolder()
    {
        return base.Channel.SerializeTaskListHolder();
    }
    
    public string SerializeDocument(long taskId)
    {
        return base.Channel.SerializeDocument(taskId);
    }
    
    public void AddAction(long taskId)
    {
        base.Channel.AddAction(taskId);
    }
    
    public void MoveAction(long taskId, long actionId, bool down)
    {
        base.Channel.MoveAction(taskId, actionId, down);
    }
    
    public void RemoveAction(long taskId, long actionId)
    {
        base.Channel.RemoveAction(taskId, actionId);
    }
    
    public void SetTaskProperty(long taskId, string propertyName, string propertyValue)
    {
        base.Channel.SetTaskProperty(taskId, propertyName, propertyValue);
    }
    
    public void SetActionProperty(long taskId, long actionId, string propertyName, string propertyValue)
    {
        base.Channel.SetActionProperty(taskId, actionId, propertyName, propertyValue);
    }
    
    public void SetScheduleProperty(long taskId, string propertyName, string propertyValue)
    {
        base.Channel.SetScheduleProperty(taskId, propertyName, propertyValue);
    }
}

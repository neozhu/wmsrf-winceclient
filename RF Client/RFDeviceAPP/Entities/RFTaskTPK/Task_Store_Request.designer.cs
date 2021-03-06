// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace> RFDeviceAPP.Common.NSPRFTM01.Request</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>True</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace RFDeviceAPP.Common.TaskStore.Request
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;



    public partial class Task
    {

        public static Task Craete(string taskDetailKey, string toLoc)
        {
            Task task = new Task();
            task.TaskHeader.TaskDetailKey = taskDetailKey;
            task.TaskHeader.ToLoc = toLoc;
            return task;
        }
        private TaskHeader taskHeader;

        public TaskHeader TaskHeader
        {
            get
            {
                if ((this.taskHeader == null))
                {
                    this.taskHeader = new TaskHeader();
                }
                return this.taskHeader;
            }
            set
            {
                this.taskHeader = value;
            }
        }
    }

    public partial class TaskHeader
    {

        private string taskDetailKeyField;

        private string toLocField;
        private string statusField;

      

        public TaskHeader()
        {
            this.taskDetailKeyField = "";
            this.toLocField = "";
            this.statusField = "3";
            
        }

        public string TaskDetailKey
        {
            get
            {
                return this.taskDetailKeyField;
            }
            set
            {
                this.taskDetailKeyField = value;
            }
        }

        public string ToLoc
        {
            get
            {
                return this.toLocField;
            }
            set
            {
                this.toLocField = value;
            }
        }


        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

         
    }
}

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CompanyJobDescription.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/CompanyJobDescription.proto</summary>
  public static partial class CompanyJobDescriptionReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/CompanyJobDescription.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompanyJobDescriptionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJQcm90b3MvQ29tcGFueUpvYkRlc2NyaXB0aW9uLnByb3RvEhBDYXJlZXJD",
            "bG91ZC5nUlBDGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8aH2dvb2ds",
            "ZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8iJQoXSWRSZXF1ZXN0Sm9iRGVz",
            "Y3JpcHRpb24SCgoCSWQYASABKAkiYQocQ29tcGFueUpvYkRlc2NyaXB0aW9u",
            "UGF5TG9hZBIKCgJJZBgBIAEoCRILCgNKb2IYAiABKAkSDwoHSm9iTmFtZRgD",
            "IAEoCRIXCg9Kb2JEZXNjcmlwdGlvbnMYBCABKAkyxAMKFUNvbXBhbnlKb2JE",
            "ZXNjcmlwdGlvbhJ2ChlSZWFkQ29tcGFueUpvYkRlc2NyaXB0aW9uEikuQ2Fy",
            "ZWVyQ2xvdWQuZ1JQQy5JZFJlcXVlc3RKb2JEZXNjcmlwdGlvbhouLkNhcmVl",
            "ckNsb3VkLmdSUEMuQ29tcGFueUpvYkRlc2NyaXB0aW9uUGF5TG9hZBJlChtD",
            "cmVhdGVDb21wYW55Sm9iRGVzY3JpcHRpb24SLi5DYXJlZXJDbG91ZC5nUlBD",
            "LkNvbXBhbnlKb2JEZXNjcmlwdGlvblBheUxvYWQaFi5nb29nbGUucHJvdG9i",
            "dWYuRW1wdHkSZQobVXBkYXRlQ29tcGFueUpvYkRlc2NyaXB0aW9uEi4uQ2Fy",
            "ZWVyQ2xvdWQuZ1JQQy5Db21wYW55Sm9iRGVzY3JpcHRpb25QYXlMb2FkGhYu",
            "Z29vZ2xlLnByb3RvYnVmLkVtcHR5EmUKG0RlbGV0ZUNvbXBhbnlKb2JEZXNj",
            "cmlwdGlvbhIuLkNhcmVlckNsb3VkLmdSUEMuQ29tcGFueUpvYkRlc2NyaXB0",
            "aW9uUGF5TG9hZBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eUIaqgIXQ2FyZWVy",
            "Q2xvdWQuZ1JQQy5Qcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.IdRequestJobDescription), global::CareerCloud.gRPC.Protos.IdRequestJobDescription.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyJobDescriptionPayLoad), global::CareerCloud.gRPC.Protos.CompanyJobDescriptionPayLoad.Parser, new[]{ "Id", "Job", "JobName", "JobDescriptions" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IdRequestJobDescription : pb::IMessage<IdRequestJobDescription> {
    private static readonly pb::MessageParser<IdRequestJobDescription> _parser = new pb::MessageParser<IdRequestJobDescription>(() => new IdRequestJobDescription());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IdRequestJobDescription> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobDescriptionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequestJobDescription() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequestJobDescription(IdRequestJobDescription other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequestJobDescription Clone() {
      return new IdRequestJobDescription(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IdRequestJobDescription);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IdRequestJobDescription other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IdRequestJobDescription other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CompanyJobDescriptionPayLoad : pb::IMessage<CompanyJobDescriptionPayLoad> {
    private static readonly pb::MessageParser<CompanyJobDescriptionPayLoad> _parser = new pb::MessageParser<CompanyJobDescriptionPayLoad>(() => new CompanyJobDescriptionPayLoad());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyJobDescriptionPayLoad> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobDescriptionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobDescriptionPayLoad() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobDescriptionPayLoad(CompanyJobDescriptionPayLoad other) : this() {
      id_ = other.id_;
      job_ = other.job_;
      jobName_ = other.jobName_;
      jobDescriptions_ = other.jobDescriptions_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobDescriptionPayLoad Clone() {
      return new CompanyJobDescriptionPayLoad(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Job" field.</summary>
    public const int JobFieldNumber = 2;
    private string job_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Job {
      get { return job_; }
      set {
        job_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "JobName" field.</summary>
    public const int JobNameFieldNumber = 3;
    private string jobName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JobName {
      get { return jobName_; }
      set {
        jobName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "JobDescriptions" field.</summary>
    public const int JobDescriptionsFieldNumber = 4;
    private string jobDescriptions_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JobDescriptions {
      get { return jobDescriptions_; }
      set {
        jobDescriptions_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyJobDescriptionPayLoad);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyJobDescriptionPayLoad other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Job != other.Job) return false;
      if (JobName != other.JobName) return false;
      if (JobDescriptions != other.JobDescriptions) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Job.Length != 0) hash ^= Job.GetHashCode();
      if (JobName.Length != 0) hash ^= JobName.GetHashCode();
      if (JobDescriptions.Length != 0) hash ^= JobDescriptions.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Job.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Job);
      }
      if (JobName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(JobName);
      }
      if (JobDescriptions.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(JobDescriptions);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Job.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Job);
      }
      if (JobName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JobName);
      }
      if (JobDescriptions.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JobDescriptions);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyJobDescriptionPayLoad other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Job.Length != 0) {
        Job = other.Job;
      }
      if (other.JobName.Length != 0) {
        JobName = other.JobName;
      }
      if (other.JobDescriptions.Length != 0) {
        JobDescriptions = other.JobDescriptions;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Job = input.ReadString();
            break;
          }
          case 26: {
            JobName = input.ReadString();
            break;
          }
          case 34: {
            JobDescriptions = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

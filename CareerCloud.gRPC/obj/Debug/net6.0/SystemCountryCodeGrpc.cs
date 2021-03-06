// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/SystemCountryCode.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CareerCloud.gRPC.Protos {
  public static partial class SystemCountryCode
  {
    static readonly string __ServiceName = "CareerCloud.gRPC.SystemCountryCode";

    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.IdRequestCountryCode> __Marshaller_CareerCloud_gRPC_IdRequestCountryCode = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.IdRequestCountryCode.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad> __Marshaller_CareerCloud_gRPC_SystemCountryCodePayLoad = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.IdRequestCountryCode, global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad> __Method_ReadSystemCountryCode = new grpc::Method<global::CareerCloud.gRPC.Protos.IdRequestCountryCode, global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadSystemCountryCode",
        __Marshaller_CareerCloud_gRPC_IdRequestCountryCode,
        __Marshaller_CareerCloud_gRPC_SystemCountryCodePayLoad);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateSystemCountryCode = new grpc::Method<global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateSystemCountryCode",
        __Marshaller_CareerCloud_gRPC_SystemCountryCodePayLoad,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateSystemCountryCode = new grpc::Method<global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateSystemCountryCode",
        __Marshaller_CareerCloud_gRPC_SystemCountryCodePayLoad,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteSystemCountryCode = new grpc::Method<global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteSystemCountryCode",
        __Marshaller_CareerCloud_gRPC_SystemCountryCodePayLoad,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CareerCloud.gRPC.Protos.SystemCountryCodeReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SystemCountryCode</summary>
    [grpc::BindServiceMethod(typeof(SystemCountryCode), "BindService")]
    public abstract partial class SystemCountryCodeBase
    {
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad> ReadSystemCountryCode(global::CareerCloud.gRPC.Protos.IdRequestCountryCode request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> CreateSystemCountryCode(global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateSystemCountryCode(global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteSystemCountryCode(global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SystemCountryCodeBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ReadSystemCountryCode, serviceImpl.ReadSystemCountryCode)
          .AddMethod(__Method_CreateSystemCountryCode, serviceImpl.CreateSystemCountryCode)
          .AddMethod(__Method_UpdateSystemCountryCode, serviceImpl.UpdateSystemCountryCode)
          .AddMethod(__Method_DeleteSystemCountryCode, serviceImpl.DeleteSystemCountryCode).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SystemCountryCodeBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ReadSystemCountryCode, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.IdRequestCountryCode, global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad>(serviceImpl.ReadSystemCountryCode));
      serviceBinder.AddMethod(__Method_CreateSystemCountryCode, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.CreateSystemCountryCode));
      serviceBinder.AddMethod(__Method_UpdateSystemCountryCode, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateSystemCountryCode));
      serviceBinder.AddMethod(__Method_DeleteSystemCountryCode, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SystemCountryCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteSystemCountryCode));
    }

  }
}
#endregion

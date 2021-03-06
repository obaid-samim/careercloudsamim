// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/SystemLanguageCode.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CareerCloud.gRPC.Protos {
  public static partial class SystemLanguageCode
  {
    static readonly string __ServiceName = "CareerCloud.gRPC.SystemLanguageCode";

    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.IdRequestLanguageCode> __Marshaller_CareerCloud_gRPC_IdRequestLanguageCode = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.IdRequestLanguageCode.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad> __Marshaller_CareerCloud_gRPC_SystemLanguageCodePayLoad = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.IdRequestLanguageCode, global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad> __Method_ReadSystemLanguageCode = new grpc::Method<global::CareerCloud.gRPC.Protos.IdRequestLanguageCode, global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadSystemLanguageCode",
        __Marshaller_CareerCloud_gRPC_IdRequestLanguageCode,
        __Marshaller_CareerCloud_gRPC_SystemLanguageCodePayLoad);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateSystemLanguageCode = new grpc::Method<global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateSystemLanguageCode",
        __Marshaller_CareerCloud_gRPC_SystemLanguageCodePayLoad,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateSystemLanguageCode = new grpc::Method<global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateSystemLanguageCode",
        __Marshaller_CareerCloud_gRPC_SystemLanguageCodePayLoad,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteSystemLanguageCode = new grpc::Method<global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteSystemLanguageCode",
        __Marshaller_CareerCloud_gRPC_SystemLanguageCodePayLoad,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CareerCloud.gRPC.Protos.SystemLanguageCodeReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SystemLanguageCode</summary>
    [grpc::BindServiceMethod(typeof(SystemLanguageCode), "BindService")]
    public abstract partial class SystemLanguageCodeBase
    {
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad> ReadSystemLanguageCode(global::CareerCloud.gRPC.Protos.IdRequestLanguageCode request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> CreateSystemLanguageCode(global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateSystemLanguageCode(global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteSystemLanguageCode(global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SystemLanguageCodeBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ReadSystemLanguageCode, serviceImpl.ReadSystemLanguageCode)
          .AddMethod(__Method_CreateSystemLanguageCode, serviceImpl.CreateSystemLanguageCode)
          .AddMethod(__Method_UpdateSystemLanguageCode, serviceImpl.UpdateSystemLanguageCode)
          .AddMethod(__Method_DeleteSystemLanguageCode, serviceImpl.DeleteSystemLanguageCode).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SystemLanguageCodeBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ReadSystemLanguageCode, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.IdRequestLanguageCode, global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad>(serviceImpl.ReadSystemLanguageCode));
      serviceBinder.AddMethod(__Method_CreateSystemLanguageCode, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.CreateSystemLanguageCode));
      serviceBinder.AddMethod(__Method_UpdateSystemLanguageCode, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateSystemLanguageCode));
      serviceBinder.AddMethod(__Method_DeleteSystemLanguageCode, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SystemLanguageCodePayLoad, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteSystemLanguageCode));
    }

  }
}
#endregion

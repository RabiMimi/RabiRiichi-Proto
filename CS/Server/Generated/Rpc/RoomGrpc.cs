// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Server/Rpc/Room.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace RabiRiichi.Server.Generated.Rpc {
  public static partial class RoomService
  {
    static readonly string __ServiceName = "RoomService";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RabiRiichi.Server.Generated.Rpc.CreateRoomResponse> __Marshaller_CreateRoomResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RabiRiichi.Server.Generated.Rpc.CreateRoomResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RabiRiichi.Server.Generated.Rpc.JoinRoomRequest> __Marshaller_JoinRoomRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RabiRiichi.Server.Generated.Rpc.JoinRoomRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::RabiRiichi.Server.Generated.Rpc.CreateRoomResponse> __Method_CreateRoom = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::RabiRiichi.Server.Generated.Rpc.CreateRoomResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateRoom",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_CreateRoomResponse);

    static readonly grpc::Method<global::RabiRiichi.Server.Generated.Rpc.JoinRoomRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_JoinRoom = new grpc::Method<global::RabiRiichi.Server.Generated.Rpc.JoinRoomRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "JoinRoom",
        __Marshaller_JoinRoomRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::RabiRiichi.Server.Generated.Rpc.RoomReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RoomService</summary>
    public abstract partial class RoomServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::RabiRiichi.Server.Generated.Rpc.CreateRoomResponse> CreateRoom(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> JoinRoom(global::RabiRiichi.Server.Generated.Rpc.JoinRoomRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RoomService</summary>
    public partial class RoomServiceClient : grpc::ClientBase<RoomServiceClient>
    {
      /// <summary>Creates a new client for RoomService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RoomServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RoomService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RoomServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RoomServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RoomServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::RabiRiichi.Server.Generated.Rpc.CreateRoomResponse CreateRoom(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateRoom(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RabiRiichi.Server.Generated.Rpc.CreateRoomResponse CreateRoom(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateRoom, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::RabiRiichi.Server.Generated.Rpc.CreateRoomResponse> CreateRoomAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateRoomAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::RabiRiichi.Server.Generated.Rpc.CreateRoomResponse> CreateRoomAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateRoom, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty JoinRoom(global::RabiRiichi.Server.Generated.Rpc.JoinRoomRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return JoinRoom(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty JoinRoom(global::RabiRiichi.Server.Generated.Rpc.JoinRoomRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_JoinRoom, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> JoinRoomAsync(global::RabiRiichi.Server.Generated.Rpc.JoinRoomRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return JoinRoomAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> JoinRoomAsync(global::RabiRiichi.Server.Generated.Rpc.JoinRoomRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_JoinRoom, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RoomServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RoomServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RoomServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateRoom, serviceImpl.CreateRoom)
          .AddMethod(__Method_JoinRoom, serviceImpl.JoinRoom).Build();
    }

  }
}
#endregion

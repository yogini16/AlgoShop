// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/StockService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace StocksService.Protos {
  public static partial class Stock
  {
    static readonly string __ServiceName = "stocks.Stock";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::StocksService.Protos.ProductRequest> __Marshaller_stocks_ProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::StocksService.Protos.ProductRequest.Parser));
    static readonly grpc::Marshaller<global::StocksService.Protos.StockResponse> __Marshaller_stocks_StockResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::StocksService.Protos.StockResponse.Parser));

    static readonly grpc::Method<global::StocksService.Protos.ProductRequest, global::StocksService.Protos.StockResponse> __Method_GetStock = new grpc::Method<global::StocksService.Protos.ProductRequest, global::StocksService.Protos.StockResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetStock",
        __Marshaller_stocks_ProductRequest,
        __Marshaller_stocks_StockResponse);

    static readonly grpc::Method<global::StocksService.Protos.ProductRequest, global::StocksService.Protos.StockResponse> __Method_IncreaseStock = new grpc::Method<global::StocksService.Protos.ProductRequest, global::StocksService.Protos.StockResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "IncreaseStock",
        __Marshaller_stocks_ProductRequest,
        __Marshaller_stocks_StockResponse);

    static readonly grpc::Method<global::StocksService.Protos.ProductRequest, global::StocksService.Protos.StockResponse> __Method_DecreaseStock = new grpc::Method<global::StocksService.Protos.ProductRequest, global::StocksService.Protos.StockResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DecreaseStock",
        __Marshaller_stocks_ProductRequest,
        __Marshaller_stocks_StockResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::StocksService.Protos.StockServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Stock</summary>
    [grpc::BindServiceMethod(typeof(Stock), "BindService")]
    public abstract partial class StockBase
    {
      public virtual global::System.Threading.Tasks.Task<global::StocksService.Protos.StockResponse> GetStock(global::StocksService.Protos.ProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::StocksService.Protos.StockResponse> IncreaseStock(global::StocksService.Protos.ProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::StocksService.Protos.StockResponse> DecreaseStock(global::StocksService.Protos.ProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Stock</summary>
    public partial class StockClient : grpc::ClientBase<StockClient>
    {
      /// <summary>Creates a new client for Stock</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public StockClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Stock that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public StockClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected StockClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected StockClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::StocksService.Protos.StockResponse GetStock(global::StocksService.Protos.ProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStock(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::StocksService.Protos.StockResponse GetStock(global::StocksService.Protos.ProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetStock, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::StocksService.Protos.StockResponse> GetStockAsync(global::StocksService.Protos.ProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStockAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::StocksService.Protos.StockResponse> GetStockAsync(global::StocksService.Protos.ProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetStock, null, options, request);
      }
      public virtual global::StocksService.Protos.StockResponse IncreaseStock(global::StocksService.Protos.ProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return IncreaseStock(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::StocksService.Protos.StockResponse IncreaseStock(global::StocksService.Protos.ProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_IncreaseStock, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::StocksService.Protos.StockResponse> IncreaseStockAsync(global::StocksService.Protos.ProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return IncreaseStockAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::StocksService.Protos.StockResponse> IncreaseStockAsync(global::StocksService.Protos.ProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_IncreaseStock, null, options, request);
      }
      public virtual global::StocksService.Protos.StockResponse DecreaseStock(global::StocksService.Protos.ProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DecreaseStock(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::StocksService.Protos.StockResponse DecreaseStock(global::StocksService.Protos.ProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DecreaseStock, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::StocksService.Protos.StockResponse> DecreaseStockAsync(global::StocksService.Protos.ProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DecreaseStockAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::StocksService.Protos.StockResponse> DecreaseStockAsync(global::StocksService.Protos.ProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DecreaseStock, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override StockClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StockClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(StockBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetStock, serviceImpl.GetStock)
          .AddMethod(__Method_IncreaseStock, serviceImpl.IncreaseStock)
          .AddMethod(__Method_DecreaseStock, serviceImpl.DecreaseStock).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, StockBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetStock, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::StocksService.Protos.ProductRequest, global::StocksService.Protos.StockResponse>(serviceImpl.GetStock));
      serviceBinder.AddMethod(__Method_IncreaseStock, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::StocksService.Protos.ProductRequest, global::StocksService.Protos.StockResponse>(serviceImpl.IncreaseStock));
      serviceBinder.AddMethod(__Method_DecreaseStock, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::StocksService.Protos.ProductRequest, global::StocksService.Protos.StockResponse>(serviceImpl.DecreaseStock));
    }

  }
}
#endregion
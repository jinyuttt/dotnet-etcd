// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gannotations.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api {

  /// <summary>Holder for reflection information generated from gannotations.proto</summary>
  public static partial class GannotationsReflection {

    #region Descriptor
    /// <summary>File descriptor for gannotations.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GannotationsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJnYW5ub3RhdGlvbnMucHJvdG8SCmdvb2dsZS5hcGkaC2dodHRwLnByb3Rv",
            "GhBkZXNjcmlwdG9yLnByb3RvOkUKBGh0dHASHi5nb29nbGUucHJvdG9idWYu",
            "TWV0aG9kT3B0aW9ucxiwyrwiIAEoCzIULmdvb2dsZS5hcGkuSHR0cFJ1bGVC",
            "bgoOY29tLmdvb2dsZS5hcGlCEEFubm90YXRpb25zUHJvdG9QAVpBZ29vZ2xl",
            "LmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hcGkvYW5ub3RhdGlv",
            "bnM7YW5ub3RhdGlvbnOiAgRHQVBJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.GhttpReflection.Descriptor, global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pb::Extension[] { GannotationsExtensions.Http }, null));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of gannotations.proto</summary>
  public static partial class GannotationsExtensions {
    /// <summary>
    /// See `HttpRule`.
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MethodOptions, global::Google.Api.HttpRule> Http =
      new pb::Extension<global::Google.Protobuf.Reflection.MethodOptions, global::Google.Api.HttpRule>(72295728, pb::FieldCodec.ForMessage(578365826, global::Google.Api.HttpRule.Parser));
  }

}

#endregion Designer generated code

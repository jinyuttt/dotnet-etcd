// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: kv.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mvccpb {

  /// <summary>Holder for reflection information generated from kv.proto</summary>
  public static partial class KvReflection {

    #region Descriptor
    /// <summary>File descriptor for kv.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KvReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cghrdi5wcm90bxIGbXZjY3BiInUKCEtleVZhbHVlEgsKA2tleRgBIAEoDBIX",
            "Cg9jcmVhdGVfcmV2aXNpb24YAiABKAMSFAoMbW9kX3JldmlzaW9uGAMgASgD",
            "Eg8KB3ZlcnNpb24YBCABKAMSDQoFdmFsdWUYBSABKAwSDQoFbGVhc2UYBiAB",
            "KAMikQEKBUV2ZW50EiUKBHR5cGUYASABKA4yFy5tdmNjcGIuRXZlbnQuRXZl",
            "bnRUeXBlEhwKAmt2GAIgASgLMhAubXZjY3BiLktleVZhbHVlEiEKB3ByZXZf",
            "a3YYAyABKAsyEC5tdmNjcGIuS2V5VmFsdWUiIAoJRXZlbnRUeXBlEgcKA1BV",
            "VBAAEgoKBkRFTEVURRABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mvccpb.KeyValue), global::Mvccpb.KeyValue.Parser, new[]{ "Key", "CreateRevision", "ModRevision", "Version", "Value", "Lease" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mvccpb.Event), global::Mvccpb.Event.Parser, new[]{ "Type", "Kv", "PrevKv" }, null, new[]{ typeof(global::Mvccpb.Event.Types.EventType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class KeyValue : pb::IMessage<KeyValue> {
    private static readonly pb::MessageParser<KeyValue> _parser = new pb::MessageParser<KeyValue>(() => new KeyValue());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeyValue> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mvccpb.KvReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeyValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeyValue(KeyValue other) : this() {
      key_ = other.key_;
      createRevision_ = other.createRevision_;
      modRevision_ = other.modRevision_;
      version_ = other.version_;
      value_ = other.value_;
      lease_ = other.lease_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeyValue Clone() {
      return new KeyValue(this);
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 1;
    private pb::ByteString key_ = pb::ByteString.Empty;
    /// <summary>
    /// key is the key in bytes. An empty key is not allowed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_revision" field.</summary>
    public const int CreateRevisionFieldNumber = 2;
    private long createRevision_;
    /// <summary>
    /// create_revision is the revision of last creation on this key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CreateRevision {
      get { return createRevision_; }
      set {
        createRevision_ = value;
      }
    }

    /// <summary>Field number for the "mod_revision" field.</summary>
    public const int ModRevisionFieldNumber = 3;
    private long modRevision_;
    /// <summary>
    /// mod_revision is the revision of last modification on this key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ModRevision {
      get { return modRevision_; }
      set {
        modRevision_ = value;
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 4;
    private long version_;
    /// <summary>
    /// version is the version of the key. A deletion resets
    /// the version to zero and any modification of the key
    /// increases its version.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 5;
    private pb::ByteString value_ = pb::ByteString.Empty;
    /// <summary>
    /// value is the value held by the key, in bytes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lease" field.</summary>
    public const int LeaseFieldNumber = 6;
    private long lease_;
    /// <summary>
    /// lease is the ID of the lease that attached to key.
    /// When the attached lease expires, the key will be deleted.
    /// If lease is 0, then no lease is attached to the key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Lease {
      get { return lease_; }
      set {
        lease_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeyValue);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeyValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Key != other.Key) return false;
      if (CreateRevision != other.CreateRevision) return false;
      if (ModRevision != other.ModRevision) return false;
      if (Version != other.Version) return false;
      if (Value != other.Value) return false;
      if (Lease != other.Lease) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      if (CreateRevision != 0L) hash ^= CreateRevision.GetHashCode();
      if (ModRevision != 0L) hash ^= ModRevision.GetHashCode();
      if (Version != 0L) hash ^= Version.GetHashCode();
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      if (Lease != 0L) hash ^= Lease.GetHashCode();
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
      if (Key.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Key);
      }
      if (CreateRevision != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(CreateRevision);
      }
      if (ModRevision != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(ModRevision);
      }
      if (Version != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Version);
      }
      if (Value.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(Value);
      }
      if (Lease != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(Lease);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Key);
      }
      if (CreateRevision != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CreateRevision);
      }
      if (ModRevision != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ModRevision);
      }
      if (Version != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Version);
      }
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Value);
      }
      if (Lease != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Lease);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeyValue other) {
      if (other == null) {
        return;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
      if (other.CreateRevision != 0L) {
        CreateRevision = other.CreateRevision;
      }
      if (other.ModRevision != 0L) {
        ModRevision = other.ModRevision;
      }
      if (other.Version != 0L) {
        Version = other.Version;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
      if (other.Lease != 0L) {
        Lease = other.Lease;
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
            Key = input.ReadBytes();
            break;
          }
          case 16: {
            CreateRevision = input.ReadInt64();
            break;
          }
          case 24: {
            ModRevision = input.ReadInt64();
            break;
          }
          case 32: {
            Version = input.ReadInt64();
            break;
          }
          case 42: {
            Value = input.ReadBytes();
            break;
          }
          case 48: {
            Lease = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Event : pb::IMessage<Event> {
    private static readonly pb::MessageParser<Event> _parser = new pb::MessageParser<Event>(() => new Event());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Event> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mvccpb.KvReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Event() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Event(Event other) : this() {
      type_ = other.type_;
      kv_ = other.kv_ != null ? other.kv_.Clone() : null;
      prevKv_ = other.prevKv_ != null ? other.prevKv_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Event Clone() {
      return new Event(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::Mvccpb.Event.Types.EventType type_ = global::Mvccpb.Event.Types.EventType.Put;
    /// <summary>
    /// type is the kind of event. If type is a PUT, it indicates
    /// new data has been stored to the key. If type is a DELETE,
    /// it indicates the key was deleted.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Mvccpb.Event.Types.EventType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "kv" field.</summary>
    public const int KvFieldNumber = 2;
    private global::Mvccpb.KeyValue kv_;
    /// <summary>
    /// kv holds the KeyValue for the event.
    /// A PUT event contains current kv pair.
    /// A PUT event with kv.Version=1 indicates the creation of a key.
    /// A DELETE/EXPIRE event contains the deleted key with
    /// its modification revision set to the revision of deletion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Mvccpb.KeyValue Kv {
      get { return kv_; }
      set {
        kv_ = value;
      }
    }

    /// <summary>Field number for the "prev_kv" field.</summary>
    public const int PrevKvFieldNumber = 3;
    private global::Mvccpb.KeyValue prevKv_;
    /// <summary>
    /// prev_kv holds the key-value pair before the event happens.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Mvccpb.KeyValue PrevKv {
      get { return prevKv_; }
      set {
        prevKv_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Event);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Event other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (!object.Equals(Kv, other.Kv)) return false;
      if (!object.Equals(PrevKv, other.PrevKv)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::Mvccpb.Event.Types.EventType.Put) hash ^= Type.GetHashCode();
      if (kv_ != null) hash ^= Kv.GetHashCode();
      if (prevKv_ != null) hash ^= PrevKv.GetHashCode();
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
      if (Type != global::Mvccpb.Event.Types.EventType.Put) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (kv_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Kv);
      }
      if (prevKv_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PrevKv);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type != global::Mvccpb.Event.Types.EventType.Put) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (kv_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Kv);
      }
      if (prevKv_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PrevKv);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Event other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::Mvccpb.Event.Types.EventType.Put) {
        Type = other.Type;
      }
      if (other.kv_ != null) {
        if (kv_ == null) {
          Kv = new global::Mvccpb.KeyValue();
        }
        Kv.MergeFrom(other.Kv);
      }
      if (other.prevKv_ != null) {
        if (prevKv_ == null) {
          PrevKv = new global::Mvccpb.KeyValue();
        }
        PrevKv.MergeFrom(other.PrevKv);
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
          case 8: {
            Type = (global::Mvccpb.Event.Types.EventType) input.ReadEnum();
            break;
          }
          case 18: {
            if (kv_ == null) {
              Kv = new global::Mvccpb.KeyValue();
            }
            input.ReadMessage(Kv);
            break;
          }
          case 26: {
            if (prevKv_ == null) {
              PrevKv = new global::Mvccpb.KeyValue();
            }
            input.ReadMessage(PrevKv);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Event message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum EventType {
        [pbr::OriginalName("PUT")] Put = 0,
        [pbr::OriginalName("DELETE")] Delete = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code

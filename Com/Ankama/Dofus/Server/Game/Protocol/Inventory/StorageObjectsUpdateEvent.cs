using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x02000435 RID: 1077
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StorageObjectsUpdateEvent : IMessage<StorageObjectsUpdateEvent>, IMessage, IEquatable<StorageObjectsUpdateEvent>, IDeepCloneable<StorageObjectsUpdateEvent>, IBufferMessage
	{
		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06003318 RID: 13080 RVA: 0x001D7284 File Offset: 0x001D5484
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<StorageObjectsUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06003319 RID: 13081 RVA: 0x001D7294 File Offset: 0x001D5494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x0600331A RID: 13082 RVA: 0x001D72A4 File Offset: 0x001D54A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x001D72B4 File Offset: 0x001D54B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageObjectsUpdateEvent()
		{
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x001D72C4 File Offset: 0x001D54C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageObjectsUpdateEvent(StorageObjectsUpdateEvent other)
		{
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x001D72D4 File Offset: 0x001D54D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageObjectsUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x0600331E RID: 13086 RVA: 0x001D72E4 File Offset: 0x001D54E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectItemInventory> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x001D72F4 File Offset: 0x001D54F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x001D7304 File Offset: 0x001D5504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(StorageObjectsUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x001D7314 File Offset: 0x001D5514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x001D7324 File Offset: 0x001D5524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x001D7334 File Offset: 0x001D5534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x001D7344 File Offset: 0x001D5544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x001D7354 File Offset: 0x001D5554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x001D7364 File Offset: 0x001D5564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(StorageObjectsUpdateEvent other)
		{
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x001D7374 File Offset: 0x001D5574
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x001D7384 File Offset: 0x001D5584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x001D7394 File Offset: 0x001D5594
		[MethodImpl(MethodImplOptions.NoInlining)]
		static StorageObjectsUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					StorageObjectsUpdateEvent._repeated_objects_codec = FieldCodec.ForMessage<ObjectItemInventory>(10U, MA8hA9n80ObjtPbmhEGb.XVInXhlssT(MA8hA9n80ObjtPbmhEGb.D4hn8C6OFiy));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 4:
					return;
				case 5:
					StorageObjectsUpdateEvent._parser = new MessageParser<StorageObjectsUpdateEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x001D749C File Offset: 0x001D569C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool y95HX5ODEbBSVAIAISGX()
		{
			return true;
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x001D74A4 File Offset: 0x001D56A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static StorageObjectsUpdateEvent GUjdt9ODXW9p5N8PEibT()
		{
			return null;
		}

		// Token: 0x040011DE RID: 4574
		private static readonly MessageParser<StorageObjectsUpdateEvent> _parser;

		// Token: 0x040011DF RID: 4575
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011E0 RID: 4576
		public const int ObjectsFieldNumber = 1;

		// Token: 0x040011E1 RID: 4577
		private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

		// Token: 0x040011E2 RID: 4578
		private readonly RepeatedField<ObjectItemInventory> objects_;

		// Token: 0x040011E3 RID: 4579
		private static StorageObjectsUpdateEvent XPF2dGOD2DmXPcDyVNcN;
	}
}

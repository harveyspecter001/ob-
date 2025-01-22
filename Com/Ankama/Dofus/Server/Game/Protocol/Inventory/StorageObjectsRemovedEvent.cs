using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x02000439 RID: 1081
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StorageObjectsRemovedEvent : IMessage<StorageObjectsRemovedEvent>, IMessage, IEquatable<StorageObjectsRemovedEvent>, IDeepCloneable<StorageObjectsRemovedEvent>, IBufferMessage
	{
		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x0600334B RID: 13131 RVA: 0x001D76A8 File Offset: 0x001D58A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StorageObjectsRemovedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x0600334C RID: 13132 RVA: 0x001D76B8 File Offset: 0x001D58B8
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

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x0600334D RID: 13133 RVA: 0x001D76C8 File Offset: 0x001D58C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x001D76D8 File Offset: 0x001D58D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageObjectsRemovedEvent()
		{
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x001D76E8 File Offset: 0x001D58E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageObjectsRemovedEvent(StorageObjectsRemovedEvent other)
		{
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x001D76F8 File Offset: 0x001D58F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageObjectsRemovedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06003351 RID: 13137 RVA: 0x001D7708 File Offset: 0x001D5908
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> ObjectsUid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x001D7718 File Offset: 0x001D5918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x001D7728 File Offset: 0x001D5928
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(StorageObjectsRemovedEvent other)
		{
			return true;
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x001D7738 File Offset: 0x001D5938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x001D7748 File Offset: 0x001D5948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x001D7758 File Offset: 0x001D5958
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x001D7768 File Offset: 0x001D5968
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x001D7778 File Offset: 0x001D5978
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x001D7788 File Offset: 0x001D5988
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(StorageObjectsRemovedEvent other)
		{
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x001D7798 File Offset: 0x001D5998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x001D77A8 File Offset: 0x001D59A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x001D77B8 File Offset: 0x001D59B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static StorageObjectsRemovedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 5:
					StorageObjectsRemovedEvent._parser = new MessageParser<StorageObjectsRemovedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				StorageObjectsRemovedEvent._repeated_objectsUid_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x001D78D0 File Offset: 0x001D5AD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OPT6iqODKnQp6UErfOcH()
		{
			return true;
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x001D78D8 File Offset: 0x001D5AD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static StorageObjectsRemovedEvent XeXgssODIBUsXQxWS8n2()
		{
			return null;
		}

		// Token: 0x040011ED RID: 4589
		private static readonly MessageParser<StorageObjectsRemovedEvent> _parser;

		// Token: 0x040011EE RID: 4590
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011EF RID: 4591
		public const int ObjectsUidFieldNumber = 1;

		// Token: 0x040011F0 RID: 4592
		private static readonly FieldCodec<int> _repeated_objectsUid_codec;

		// Token: 0x040011F1 RID: 4593
		private readonly RepeatedField<int> objectsUid_;

		// Token: 0x040011F2 RID: 4594
		internal static StorageObjectsRemovedEvent I53T4wODjH6AJaYjhL2y;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x02000437 RID: 1079
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StorageObjectRemovedEvent : IMessage<StorageObjectRemovedEvent>, IMessage, IEquatable<StorageObjectRemovedEvent>, IDeepCloneable<StorageObjectRemovedEvent>, IBufferMessage
	{
		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06003331 RID: 13105 RVA: 0x001D74AC File Offset: 0x001D56AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<StorageObjectRemovedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06003332 RID: 13106 RVA: 0x001D74BC File Offset: 0x001D56BC
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

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06003333 RID: 13107 RVA: 0x001D74CC File Offset: 0x001D56CC
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

		// Token: 0x06003334 RID: 13108 RVA: 0x001D74DC File Offset: 0x001D56DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageObjectRemovedEvent()
		{
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x001D74EC File Offset: 0x001D56EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageObjectRemovedEvent(StorageObjectRemovedEvent other)
		{
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x001D74FC File Offset: 0x001D56FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageObjectRemovedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06003337 RID: 13111 RVA: 0x001D750C File Offset: 0x001D570C
		// (set) Token: 0x06003338 RID: 13112 RVA: 0x001D751C File Offset: 0x001D571C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectUid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x001D752C File Offset: 0x001D572C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x001D753C File Offset: 0x001D573C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(StorageObjectRemovedEvent other)
		{
			return true;
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x001D754C File Offset: 0x001D574C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x001D755C File Offset: 0x001D575C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x001D756C File Offset: 0x001D576C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x001D757C File Offset: 0x001D577C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x001D758C File Offset: 0x001D578C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x001D759C File Offset: 0x001D579C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(StorageObjectRemovedEvent other)
		{
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x001D75AC File Offset: 0x001D57AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x001D75BC File Offset: 0x001D57BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x001D75CC File Offset: 0x001D57CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static StorageObjectRemovedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 4:
					StorageObjectRemovedEvent._parser = new MessageParser<StorageObjectRemovedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x001D7698 File Offset: 0x001D5898
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ljPTBMODxjlfkblMFwI3()
		{
			return true;
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x001D76A0 File Offset: 0x001D58A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static StorageObjectRemovedEvent J5QbtwOD4XOxYA9fAr5h()
		{
			return null;
		}

		// Token: 0x040011E6 RID: 4582
		private static readonly MessageParser<StorageObjectRemovedEvent> _parser;

		// Token: 0x040011E7 RID: 4583
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011E8 RID: 4584
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x040011E9 RID: 4585
		private int objectUid_;

		// Token: 0x040011EA RID: 4586
		private static StorageObjectRemovedEvent eQOgt2ODNSYDKNTK4RTq;
	}
}

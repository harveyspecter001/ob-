using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CA1 RID: 3233
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CosmeticInventoryAddedEvent : IMessage<CosmeticInventoryAddedEvent>, IMessage, IEquatable<CosmeticInventoryAddedEvent>, IDeepCloneable<CosmeticInventoryAddedEvent>, IBufferMessage
	{
		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x06009B3A RID: 39738 RVA: 0x0027FE94 File Offset: 0x0027E094
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CosmeticInventoryAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x06009B3B RID: 39739 RVA: 0x0027FEA4 File Offset: 0x0027E0A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x06009B3C RID: 39740 RVA: 0x0027FEB4 File Offset: 0x0027E0B4
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

		// Token: 0x06009B3D RID: 39741 RVA: 0x0027FEC4 File Offset: 0x0027E0C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryAddedEvent()
		{
		}

		// Token: 0x06009B3E RID: 39742 RVA: 0x0027FED4 File Offset: 0x0027E0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryAddedEvent(CosmeticInventoryAddedEvent other)
		{
		}

		// Token: 0x06009B3F RID: 39743 RVA: 0x0027FEE4 File Offset: 0x0027E0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x06009B40 RID: 39744 RVA: 0x0027FEF4 File Offset: 0x0027E0F4
		// (set) Token: 0x06009B41 RID: 39745 RVA: 0x0027FF04 File Offset: 0x0027E104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ObjectItem Object
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009B42 RID: 39746 RVA: 0x0027FF14 File Offset: 0x0027E114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009B43 RID: 39747 RVA: 0x0027FF24 File Offset: 0x0027E124
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CosmeticInventoryAddedEvent other)
		{
			return true;
		}

		// Token: 0x06009B44 RID: 39748 RVA: 0x0027FF34 File Offset: 0x0027E134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009B45 RID: 39749 RVA: 0x0027FF44 File Offset: 0x0027E144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009B46 RID: 39750 RVA: 0x0027FF54 File Offset: 0x0027E154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009B47 RID: 39751 RVA: 0x0027FF64 File Offset: 0x0027E164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009B48 RID: 39752 RVA: 0x0027FF74 File Offset: 0x0027E174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009B49 RID: 39753 RVA: 0x0027FF84 File Offset: 0x0027E184
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CosmeticInventoryAddedEvent other)
		{
		}

		// Token: 0x06009B4A RID: 39754 RVA: 0x0027FF94 File Offset: 0x0027E194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009B4B RID: 39755 RVA: 0x0027FFA4 File Offset: 0x0027E1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009B4C RID: 39756 RVA: 0x0027FFB4 File Offset: 0x0027E1B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CosmeticInventoryAddedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				CosmeticInventoryAddedEvent._parser = new MessageParser<CosmeticInventoryAddedEvent>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x06009B4D RID: 39757 RVA: 0x00280098 File Offset: 0x0027E298
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DVqgC0Jxtaw2GtUJxfS3()
		{
			return true;
		}

		// Token: 0x06009B4E RID: 39758 RVA: 0x002800A0 File Offset: 0x0027E2A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CosmeticInventoryAddedEvent T5mrpwJxwZOGCT7Dt8bB()
		{
			return null;
		}

		// Token: 0x040039A3 RID: 14755
		private static readonly MessageParser<CosmeticInventoryAddedEvent> _parser;

		// Token: 0x040039A4 RID: 14756
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039A5 RID: 14757
		public const int ObjectFieldNumber = 1;

		// Token: 0x040039A6 RID: 14758
		private ObjectItem object_;

		// Token: 0x040039A7 RID: 14759
		private static CosmeticInventoryAddedEvent K8ZVspJxDBW2ZUNcJJpg;
	}
}

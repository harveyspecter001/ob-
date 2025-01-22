using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x020003F0 RID: 1008
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectUseOnCellRequest : IMessage<ObjectUseOnCellRequest>, IMessage, IEquatable<ObjectUseOnCellRequest>, IDeepCloneable<ObjectUseOnCellRequest>, IBufferMessage
	{
		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06002F80 RID: 12160 RVA: 0x001D2ABC File Offset: 0x001D0CBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectUseOnCellRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06002F81 RID: 12161 RVA: 0x001D2ACC File Offset: 0x001D0CCC
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

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06002F82 RID: 12162 RVA: 0x001D2ADC File Offset: 0x001D0CDC
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

		// Token: 0x06002F83 RID: 12163 RVA: 0x001D2AEC File Offset: 0x001D0CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectUseOnCellRequest()
		{
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x001D2AFC File Offset: 0x001D0CFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectUseOnCellRequest(ObjectUseOnCellRequest other)
		{
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x001D2B0C File Offset: 0x001D0D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectUseOnCellRequest Clone()
		{
			return null;
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06002F86 RID: 12166 RVA: 0x001D2B1C File Offset: 0x001D0D1C
		// (set) Token: 0x06002F87 RID: 12167 RVA: 0x001D2B2C File Offset: 0x001D0D2C
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

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06002F88 RID: 12168 RVA: 0x001D2B3C File Offset: 0x001D0D3C
		// (set) Token: 0x06002F89 RID: 12169 RVA: 0x001D2B4C File Offset: 0x001D0D4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CellId
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

		// Token: 0x06002F8A RID: 12170 RVA: 0x001D2B5C File Offset: 0x001D0D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x001D2B6C File Offset: 0x001D0D6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectUseOnCellRequest other)
		{
			return true;
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x001D2B7C File Offset: 0x001D0D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x001D2B8C File Offset: 0x001D0D8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x001D2B9C File Offset: 0x001D0D9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x001D2BAC File Offset: 0x001D0DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x001D2BBC File Offset: 0x001D0DBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x001D2BCC File Offset: 0x001D0DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectUseOnCellRequest other)
		{
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x001D2BDC File Offset: 0x001D0DDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x001D2BEC File Offset: 0x001D0DEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x001D2BFC File Offset: 0x001D0DFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectUseOnCellRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 != 0)
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_83;
					}
					ObjectUseOnCellRequest._parser = new MessageParser<ObjectUseOnCellRequest>(() => null);
					num2 = 2;
				}
				IL_83:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x001D2CCC File Offset: 0x001D0ECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fLLnlKO0CoIvN7kulZ0J()
		{
			return true;
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x001D2CD4 File Offset: 0x001D0ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectUseOnCellRequest YdxwkUO0DQ2PrIDyFSQp()
		{
			return null;
		}

		// Token: 0x040010B3 RID: 4275
		private static readonly MessageParser<ObjectUseOnCellRequest> _parser;

		// Token: 0x040010B4 RID: 4276
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010B5 RID: 4277
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x040010B6 RID: 4278
		private int objectUid_;

		// Token: 0x040010B7 RID: 4279
		public const int CellIdFieldNumber = 2;

		// Token: 0x040010B8 RID: 4280
		private int cellId_;

		// Token: 0x040010B9 RID: 4281
		internal static ObjectUseOnCellRequest Ho30LIO00mxWCVvM0gEO;
	}
}

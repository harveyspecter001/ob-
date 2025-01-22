using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x020003E4 RID: 996
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectSetPositionRequest : IMessage<ObjectSetPositionRequest>, IMessage, IEquatable<ObjectSetPositionRequest>, IDeepCloneable<ObjectSetPositionRequest>, IBufferMessage
	{
		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06002EDC RID: 11996 RVA: 0x001D1E00 File Offset: 0x001D0000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectSetPositionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x001D1E10 File Offset: 0x001D0010
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

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06002EDE RID: 11998 RVA: 0x001D1E20 File Offset: 0x001D0020
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

		// Token: 0x06002EDF RID: 11999 RVA: 0x001D1E30 File Offset: 0x001D0030
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectSetPositionRequest()
		{
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x001D1E40 File Offset: 0x001D0040
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectSetPositionRequest(ObjectSetPositionRequest other)
		{
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x001D1E50 File Offset: 0x001D0050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectSetPositionRequest Clone()
		{
			return null;
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06002EE2 RID: 12002 RVA: 0x001D1E60 File Offset: 0x001D0060
		// (set) Token: 0x06002EE3 RID: 12003 RVA: 0x001D1E70 File Offset: 0x001D0070
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06002EE4 RID: 12004 RVA: 0x001D1E80 File Offset: 0x001D0080
		// (set) Token: 0x06002EE5 RID: 12005 RVA: 0x001D1E90 File Offset: 0x001D0090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Position
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

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x001D1EA0 File Offset: 0x001D00A0
		// (set) Token: 0x06002EE7 RID: 12007 RVA: 0x001D1EB0 File Offset: 0x001D00B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Quantity
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

		// Token: 0x06002EE8 RID: 12008 RVA: 0x001D1EC0 File Offset: 0x001D00C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x001D1ED0 File Offset: 0x001D00D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectSetPositionRequest other)
		{
			return true;
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x001D1EE0 File Offset: 0x001D00E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x001D1EF0 File Offset: 0x001D00F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x001D1F00 File Offset: 0x001D0100
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x001D1F10 File Offset: 0x001D0110
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x001D1F20 File Offset: 0x001D0120
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002EEF RID: 12015 RVA: 0x001D1F30 File Offset: 0x001D0130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectSetPositionRequest other)
		{
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x001D1F40 File Offset: 0x001D0140
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x001D1F50 File Offset: 0x001D0150
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x001D1F60 File Offset: 0x001D0160
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectSetPositionRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					ObjectSetPositionRequest._parser = new MessageParser<ObjectSetPositionRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x001D202C File Offset: 0x001D022C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EQR0uJO0IODMQoovTsxE()
		{
			return true;
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x001D2034 File Offset: 0x001D0234
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectSetPositionRequest JAjKKFO0krHh2U6C3xgo()
		{
			return null;
		}

		// Token: 0x04001081 RID: 4225
		private static readonly MessageParser<ObjectSetPositionRequest> _parser;

		// Token: 0x04001082 RID: 4226
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001083 RID: 4227
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x04001084 RID: 4228
		private int objectUid_;

		// Token: 0x04001085 RID: 4229
		public const int PositionFieldNumber = 2;

		// Token: 0x04001086 RID: 4230
		private int position_;

		// Token: 0x04001087 RID: 4231
		public const int QuantityFieldNumber = 3;

		// Token: 0x04001088 RID: 4232
		private int quantity_;

		// Token: 0x04001089 RID: 4233
		internal static ObjectSetPositionRequest X6K4L4O0KSle2TEf1OfJ;
	}
}

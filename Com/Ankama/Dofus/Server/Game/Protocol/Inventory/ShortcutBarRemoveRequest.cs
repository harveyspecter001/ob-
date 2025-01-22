using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x020003E0 RID: 992
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShortcutBarRemoveRequest : IMessage<ShortcutBarRemoveRequest>, IMessage, IEquatable<ShortcutBarRemoveRequest>, IDeepCloneable<ShortcutBarRemoveRequest>, IBufferMessage
	{
		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06002EA2 RID: 11938 RVA: 0x001D19A0 File Offset: 0x001CFBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShortcutBarRemoveRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06002EA3 RID: 11939 RVA: 0x001D19B0 File Offset: 0x001CFBB0
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

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06002EA4 RID: 11940 RVA: 0x001D19C0 File Offset: 0x001CFBC0
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

		// Token: 0x06002EA5 RID: 11941 RVA: 0x001D19D0 File Offset: 0x001CFBD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarRemoveRequest()
		{
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x001D19E0 File Offset: 0x001CFBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarRemoveRequest(ShortcutBarRemoveRequest other)
		{
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x001D19F0 File Offset: 0x001CFBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutBarRemoveRequest Clone()
		{
			return null;
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06002EA8 RID: 11944 RVA: 0x001D1A00 File Offset: 0x001CFC00
		// (set) Token: 0x06002EA9 RID: 11945 RVA: 0x001D1A14 File Offset: 0x001CFC14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ShortcutBar BarType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ShortcutBar)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06002EAA RID: 11946 RVA: 0x001D1A24 File Offset: 0x001CFC24
		// (set) Token: 0x06002EAB RID: 11947 RVA: 0x001D1A34 File Offset: 0x001CFC34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SlotId
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

		// Token: 0x06002EAC RID: 11948 RVA: 0x001D1A44 File Offset: 0x001CFC44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x001D1A54 File Offset: 0x001CFC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShortcutBarRemoveRequest other)
		{
			return true;
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x001D1A64 File Offset: 0x001CFC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x001D1A74 File Offset: 0x001CFC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x001D1A84 File Offset: 0x001CFC84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x001D1A94 File Offset: 0x001CFC94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x001D1AA4 File Offset: 0x001CFCA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x001D1AB4 File Offset: 0x001CFCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShortcutBarRemoveRequest other)
		{
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x001D1AC4 File Offset: 0x001CFCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x001D1AD4 File Offset: 0x001CFCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x001D1AE4 File Offset: 0x001CFCE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShortcutBarRemoveRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ShortcutBarRemoveRequest._parser = new MessageParser<ShortcutBarRemoveRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x001D1BB0 File Offset: 0x001CFDB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool imiFdiO0XAo18gwqqL51()
		{
			return true;
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x001D1BB8 File Offset: 0x001CFDB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShortcutBarRemoveRequest aoXSdfO0N7r81ynCAyEs()
		{
			return null;
		}

		// Token: 0x0400106D RID: 4205
		private static readonly MessageParser<ShortcutBarRemoveRequest> _parser;

		// Token: 0x0400106E RID: 4206
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400106F RID: 4207
		public const int BarTypeFieldNumber = 1;

		// Token: 0x04001070 RID: 4208
		private ShortcutBar barType_;

		// Token: 0x04001071 RID: 4209
		public const int SlotIdFieldNumber = 2;

		// Token: 0x04001072 RID: 4210
		private int slotId_;

		// Token: 0x04001073 RID: 4211
		internal static ShortcutBarRemoveRequest f7BQAfO0EQV6lpcoM060;
	}
}

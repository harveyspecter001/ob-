using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action
{
	// Token: 0x020005BB RID: 1467
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameActionFightCastRequest : IMessage<GameActionFightCastRequest>, IMessage, IEquatable<GameActionFightCastRequest>, IDeepCloneable<GameActionFightCastRequest>, IBufferMessage
	{
		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x001FD760 File Offset: 0x001FB960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameActionFightCastRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x060046B5 RID: 18101 RVA: 0x001FD770 File Offset: 0x001FB970
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

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x060046B6 RID: 18102 RVA: 0x001FD780 File Offset: 0x001FB980
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

		// Token: 0x060046B7 RID: 18103 RVA: 0x001FD790 File Offset: 0x001FB990
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionFightCastRequest()
		{
		}

		// Token: 0x060046B8 RID: 18104 RVA: 0x001FD7A0 File Offset: 0x001FB9A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionFightCastRequest(GameActionFightCastRequest other)
		{
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x001FD7B0 File Offset: 0x001FB9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionFightCastRequest Clone()
		{
			return null;
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x060046BA RID: 18106 RVA: 0x001FD7C0 File Offset: 0x001FB9C0
		// (set) Token: 0x060046BB RID: 18107 RVA: 0x001FD7D0 File Offset: 0x001FB9D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SpellId
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

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x060046BC RID: 18108 RVA: 0x001FD7E0 File Offset: 0x001FB9E0
		// (set) Token: 0x060046BD RID: 18109 RVA: 0x001FD7F0 File Offset: 0x001FB9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Cell
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

		// Token: 0x060046BE RID: 18110 RVA: 0x001FD800 File Offset: 0x001FBA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060046BF RID: 18111 RVA: 0x001FD810 File Offset: 0x001FBA10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GameActionFightCastRequest other)
		{
			return true;
		}

		// Token: 0x060046C0 RID: 18112 RVA: 0x001FD820 File Offset: 0x001FBA20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060046C1 RID: 18113 RVA: 0x001FD830 File Offset: 0x001FBA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060046C2 RID: 18114 RVA: 0x001FD840 File Offset: 0x001FBA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060046C3 RID: 18115 RVA: 0x001FD850 File Offset: 0x001FBA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060046C4 RID: 18116 RVA: 0x001FD860 File Offset: 0x001FBA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x001FD870 File Offset: 0x001FBA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GameActionFightCastRequest other)
		{
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x001FD880 File Offset: 0x001FBA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x001FD890 File Offset: 0x001FBA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x001FD8A0 File Offset: 0x001FBAA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GameActionFightCastRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					GameActionFightCastRequest._parser = new MessageParser<GameActionFightCastRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x001FD984 File Offset: 0x001FBB84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rp1wRvObayEuSAgNApfM()
		{
			return true;
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x001FD98C File Offset: 0x001FBB8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GameActionFightCastRequest MPWHs9Ob5GREK7uIaVfd()
		{
			return null;
		}

		// Token: 0x04001883 RID: 6275
		private static readonly MessageParser<GameActionFightCastRequest> _parser;

		// Token: 0x04001884 RID: 6276
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001885 RID: 6277
		public const int SpellIdFieldNumber = 1;

		// Token: 0x04001886 RID: 6278
		private int spellId_;

		// Token: 0x04001887 RID: 6279
		public const int CellFieldNumber = 2;

		// Token: 0x04001888 RID: 6280
		private int cell_;

		// Token: 0x04001889 RID: 6281
		internal static GameActionFightCastRequest IkF0UKOb186fsZ8IgieQ;
	}
}

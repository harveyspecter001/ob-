using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action
{
	// Token: 0x020005BD RID: 1469
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameActionFightCastOnTargetRequest : IMessage<GameActionFightCastOnTargetRequest>, IMessage, IEquatable<GameActionFightCastOnTargetRequest>, IDeepCloneable<GameActionFightCastOnTargetRequest>, IBufferMessage
	{
		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x060046D0 RID: 18128 RVA: 0x001FD994 File Offset: 0x001FBB94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GameActionFightCastOnTargetRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x060046D1 RID: 18129 RVA: 0x001FD9A4 File Offset: 0x001FBBA4
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

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x060046D2 RID: 18130 RVA: 0x001FD9B4 File Offset: 0x001FBBB4
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

		// Token: 0x060046D3 RID: 18131 RVA: 0x001FD9C4 File Offset: 0x001FBBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionFightCastOnTargetRequest()
		{
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x001FD9D4 File Offset: 0x001FBBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionFightCastOnTargetRequest(GameActionFightCastOnTargetRequest other)
		{
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x001FD9E4 File Offset: 0x001FBBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionFightCastOnTargetRequest Clone()
		{
			return null;
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x060046D6 RID: 18134 RVA: 0x001FD9F4 File Offset: 0x001FBBF4
		// (set) Token: 0x060046D7 RID: 18135 RVA: 0x001FDA04 File Offset: 0x001FBC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x060046D8 RID: 18136 RVA: 0x001FDA14 File Offset: 0x001FBC14
		// (set) Token: 0x060046D9 RID: 18137 RVA: 0x001FDA24 File Offset: 0x001FBC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060046DA RID: 18138 RVA: 0x001FDA34 File Offset: 0x001FBC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x001FDA44 File Offset: 0x001FBC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GameActionFightCastOnTargetRequest other)
		{
			return true;
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x001FDA54 File Offset: 0x001FBC54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x001FDA64 File Offset: 0x001FBC64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x001FDA74 File Offset: 0x001FBC74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x001FDA84 File Offset: 0x001FBC84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x001FDA94 File Offset: 0x001FBC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x001FDAA4 File Offset: 0x001FBCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GameActionFightCastOnTargetRequest other)
		{
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x001FDAB4 File Offset: 0x001FBCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x001FDAC4 File Offset: 0x001FBCC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x001FDAD4 File Offset: 0x001FBCD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GameActionFightCastOnTargetRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					GameActionFightCastOnTargetRequest._parser = new MessageParser<GameActionFightCastOnTargetRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x001FDBCC File Offset: 0x001FBDCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RTyPtxOb6I7CdwUTPtob()
		{
			return true;
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x001FDBD4 File Offset: 0x001FBDD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GameActionFightCastOnTargetRequest cpFghsObLsAQhEJqnTfq()
		{
			return null;
		}

		// Token: 0x0400188C RID: 6284
		private static readonly MessageParser<GameActionFightCastOnTargetRequest> _parser;

		// Token: 0x0400188D RID: 6285
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400188E RID: 6286
		public const int SpellIdFieldNumber = 1;

		// Token: 0x0400188F RID: 6287
		private int spellId_;

		// Token: 0x04001890 RID: 6288
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04001891 RID: 6289
		private long targetId_;

		// Token: 0x04001892 RID: 6290
		internal static GameActionFightCastOnTargetRequest ID7ZiZObyupg0j6uIN8w;
	}
}

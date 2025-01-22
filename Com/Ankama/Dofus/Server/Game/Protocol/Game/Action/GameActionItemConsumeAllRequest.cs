using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action
{
	// Token: 0x020005B9 RID: 1465
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameActionItemConsumeAllRequest : IMessage<GameActionItemConsumeAllRequest>, IMessage, IEquatable<GameActionItemConsumeAllRequest>, IDeepCloneable<GameActionItemConsumeAllRequest>, IBufferMessage
	{
		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x0600469A RID: 18074 RVA: 0x001FD560 File Offset: 0x001FB760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameActionItemConsumeAllRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x0600469B RID: 18075 RVA: 0x001FD570 File Offset: 0x001FB770
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

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x0600469C RID: 18076 RVA: 0x001FD580 File Offset: 0x001FB780
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

		// Token: 0x0600469D RID: 18077 RVA: 0x001FD590 File Offset: 0x001FB790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionItemConsumeAllRequest()
		{
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x001FD5A0 File Offset: 0x001FB7A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionItemConsumeAllRequest(GameActionItemConsumeAllRequest other)
		{
		}

		// Token: 0x0600469F RID: 18079 RVA: 0x001FD5B0 File Offset: 0x001FB7B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionItemConsumeAllRequest Clone()
		{
			return null;
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x060046A0 RID: 18080 RVA: 0x001FD5C0 File Offset: 0x001FB7C0
		// (set) Token: 0x060046A1 RID: 18081 RVA: 0x001FD5D0 File Offset: 0x001FB7D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PlayerId
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

		// Token: 0x060046A2 RID: 18082 RVA: 0x001FD5E0 File Offset: 0x001FB7E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060046A3 RID: 18083 RVA: 0x001FD5F0 File Offset: 0x001FB7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GameActionItemConsumeAllRequest other)
		{
			return true;
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x001FD600 File Offset: 0x001FB800
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x001FD610 File Offset: 0x001FB810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x001FD620 File Offset: 0x001FB820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060046A7 RID: 18087 RVA: 0x001FD630 File Offset: 0x001FB830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060046A8 RID: 18088 RVA: 0x001FD640 File Offset: 0x001FB840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060046A9 RID: 18089 RVA: 0x001FD650 File Offset: 0x001FB850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GameActionItemConsumeAllRequest other)
		{
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x001FD660 File Offset: 0x001FB860
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060046AB RID: 18091 RVA: 0x001FD670 File Offset: 0x001FB870
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x001FD680 File Offset: 0x001FB880
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GameActionItemConsumeAllRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						GameActionItemConsumeAllRequest._parser = new MessageParser<GameActionItemConsumeAllRequest>(() => null);
						num2 = 4;
						continue;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						return;
					}
					break;
				}
				IL_88:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
				continue;
				goto IL_88;
			}
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x001FD750 File Offset: 0x001FB950
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KtZpcJObvcTEDp1cgCLY()
		{
			return true;
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x001FD758 File Offset: 0x001FB958
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GameActionItemConsumeAllRequest PNhrKrObo3QKAsFPnThY()
		{
			return null;
		}

		// Token: 0x0400187C RID: 6268
		private static readonly MessageParser<GameActionItemConsumeAllRequest> _parser;

		// Token: 0x0400187D RID: 6269
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400187E RID: 6270
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x0400187F RID: 6271
		private long playerId_;

		// Token: 0x04001880 RID: 6272
		private static GameActionItemConsumeAllRequest N7YnL1ObU3oiHqLKlRkN;
	}
}

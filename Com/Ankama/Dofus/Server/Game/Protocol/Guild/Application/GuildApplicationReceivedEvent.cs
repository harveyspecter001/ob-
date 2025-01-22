using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application
{
	// Token: 0x0200056F RID: 1391
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildApplicationReceivedEvent : IMessage<GuildApplicationReceivedEvent>, IMessage, IEquatable<GuildApplicationReceivedEvent>, IDeepCloneable<GuildApplicationReceivedEvent>, IBufferMessage
	{
		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060042F4 RID: 17140 RVA: 0x001F26FC File Offset: 0x001F08FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildApplicationReceivedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x060042F5 RID: 17141 RVA: 0x001F270C File Offset: 0x001F090C
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

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060042F6 RID: 17142 RVA: 0x001F271C File Offset: 0x001F091C
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

		// Token: 0x060042F7 RID: 17143 RVA: 0x001F272C File Offset: 0x001F092C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationReceivedEvent()
		{
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x001F273C File Offset: 0x001F093C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationReceivedEvent(GuildApplicationReceivedEvent other)
		{
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x001F274C File Offset: 0x001F094C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationReceivedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x060042FA RID: 17146 RVA: 0x001F275C File Offset: 0x001F095C
		// (set) Token: 0x060042FB RID: 17147 RVA: 0x001F276C File Offset: 0x001F096C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PlayerName
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

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x060042FC RID: 17148 RVA: 0x001F277C File Offset: 0x001F097C
		// (set) Token: 0x060042FD RID: 17149 RVA: 0x001F278C File Offset: 0x001F098C
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

		// Token: 0x060042FE RID: 17150 RVA: 0x001F279C File Offset: 0x001F099C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x001F27AC File Offset: 0x001F09AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildApplicationReceivedEvent other)
		{
			return true;
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x001F27BC File Offset: 0x001F09BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x001F27CC File Offset: 0x001F09CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x001F27DC File Offset: 0x001F09DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x001F27EC File Offset: 0x001F09EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x001F27FC File Offset: 0x001F09FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x001F280C File Offset: 0x001F0A0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildApplicationReceivedEvent other)
		{
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x001F281C File Offset: 0x001F0A1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x001F282C File Offset: 0x001F0A2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x001F283C File Offset: 0x001F0A3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildApplicationReceivedEvent()
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
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					GuildApplicationReceivedEvent._parser = new MessageParser<GuildApplicationReceivedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x001F2934 File Offset: 0x001F0B34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vw7QwGOHCo0HNFhPo1Vj()
		{
			return true;
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x001F293C File Offset: 0x001F0B3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildApplicationReceivedEvent MOYtjEOHDCyGphfWgZ58()
		{
			return null;
		}

		// Token: 0x04001717 RID: 5911
		private static readonly MessageParser<GuildApplicationReceivedEvent> _parser;

		// Token: 0x04001718 RID: 5912
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001719 RID: 5913
		public const int PlayerNameFieldNumber = 1;

		// Token: 0x0400171A RID: 5914
		private string playerName_;

		// Token: 0x0400171B RID: 5915
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x0400171C RID: 5916
		private long playerId_;

		// Token: 0x0400171D RID: 5917
		internal static GuildApplicationReceivedEvent GVGGYnOH0JN7BR59WUIc;
	}
}

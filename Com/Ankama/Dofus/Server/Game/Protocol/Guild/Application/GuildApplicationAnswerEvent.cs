using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application
{
	// Token: 0x02000569 RID: 1385
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildApplicationAnswerEvent : IMessage<GuildApplicationAnswerEvent>, IMessage, IEquatable<GuildApplicationAnswerEvent>, IDeepCloneable<GuildApplicationAnswerEvent>, IBufferMessage
	{
		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x0600429B RID: 17051 RVA: 0x001F2004 File Offset: 0x001F0204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildApplicationAnswerEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x0600429C RID: 17052 RVA: 0x001F2014 File Offset: 0x001F0214
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

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x0600429D RID: 17053 RVA: 0x001F2024 File Offset: 0x001F0224
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

		// Token: 0x0600429E RID: 17054 RVA: 0x001F2034 File Offset: 0x001F0234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationAnswerEvent()
		{
		}

		// Token: 0x0600429F RID: 17055 RVA: 0x001F2044 File Offset: 0x001F0244
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationAnswerEvent(GuildApplicationAnswerEvent other)
		{
		}

		// Token: 0x060042A0 RID: 17056 RVA: 0x001F2054 File Offset: 0x001F0254
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationAnswerEvent Clone()
		{
			return null;
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x060042A1 RID: 17057 RVA: 0x001F2064 File Offset: 0x001F0264
		// (set) Token: 0x060042A2 RID: 17058 RVA: 0x001F2074 File Offset: 0x001F0274
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Accepted
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x060042A3 RID: 17059 RVA: 0x001F2084 File Offset: 0x001F0284
		// (set) Token: 0x060042A4 RID: 17060 RVA: 0x001F2094 File Offset: 0x001F0294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuildInformation GuildInformation
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

		// Token: 0x060042A5 RID: 17061 RVA: 0x001F20A4 File Offset: 0x001F02A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x001F20B4 File Offset: 0x001F02B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildApplicationAnswerEvent other)
		{
			return true;
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x001F20C4 File Offset: 0x001F02C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x001F20D4 File Offset: 0x001F02D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060042A9 RID: 17065 RVA: 0x001F20E4 File Offset: 0x001F02E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x001F20F4 File Offset: 0x001F02F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x001F2104 File Offset: 0x001F0304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x001F2114 File Offset: 0x001F0314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildApplicationAnswerEvent other)
		{
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x001F2124 File Offset: 0x001F0324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x001F2134 File Offset: 0x001F0334
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x001F2144 File Offset: 0x001F0344
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildApplicationAnswerEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					GuildApplicationAnswerEvent._parser = new MessageParser<GuildApplicationAnswerEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x001F223C File Offset: 0x001F043C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wE6tLaOH5NhNI6Hih2kt()
		{
			return true;
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x001F2244 File Offset: 0x001F0444
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildApplicationAnswerEvent zhucdAOHywo9MajF2DWT()
		{
			return null;
		}

		// Token: 0x040016F5 RID: 5877
		private static readonly MessageParser<GuildApplicationAnswerEvent> _parser;

		// Token: 0x040016F6 RID: 5878
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016F7 RID: 5879
		public const int AcceptedFieldNumber = 1;

		// Token: 0x040016F8 RID: 5880
		private bool accepted_;

		// Token: 0x040016F9 RID: 5881
		public const int GuildInformationFieldNumber = 2;

		// Token: 0x040016FA RID: 5882
		private GuildInformation guildInformation_;

		// Token: 0x040016FB RID: 5883
		internal static GuildApplicationAnswerEvent O3O1tDOHa4gpEvEK05iZ;
	}
}

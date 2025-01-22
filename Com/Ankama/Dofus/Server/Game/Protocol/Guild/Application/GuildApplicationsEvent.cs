using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application
{
	// Token: 0x0200056B RID: 1387
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildApplicationsEvent : IMessage<GuildApplicationsEvent>, IMessage, IEquatable<GuildApplicationsEvent>, IDeepCloneable<GuildApplicationsEvent>, IBufferMessage
	{
		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x060042B7 RID: 17079 RVA: 0x001F224C File Offset: 0x001F044C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildApplicationsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x060042B8 RID: 17080 RVA: 0x001F225C File Offset: 0x001F045C
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

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x060042B9 RID: 17081 RVA: 0x001F226C File Offset: 0x001F046C
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

		// Token: 0x060042BA RID: 17082 RVA: 0x001F227C File Offset: 0x001F047C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationsEvent()
		{
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x001F228C File Offset: 0x001F048C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationsEvent(GuildApplicationsEvent other)
		{
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x001F229C File Offset: 0x001F049C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationsEvent Clone()
		{
			return null;
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x060042BD RID: 17085 RVA: 0x001F22AC File Offset: 0x001F04AC
		// (set) Token: 0x060042BE RID: 17086 RVA: 0x001F22BC File Offset: 0x001F04BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Offset
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

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x060042BF RID: 17087 RVA: 0x001F22CC File Offset: 0x001F04CC
		// (set) Token: 0x060042C0 RID: 17088 RVA: 0x001F22DC File Offset: 0x001F04DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Count
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

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060042C1 RID: 17089 RVA: 0x001F22EC File Offset: 0x001F04EC
		// (set) Token: 0x060042C2 RID: 17090 RVA: 0x001F22FC File Offset: 0x001F04FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Total
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

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x060042C3 RID: 17091 RVA: 0x001F230C File Offset: 0x001F050C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SocialApplicationInformation> Applies
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x001F231C File Offset: 0x001F051C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x001F232C File Offset: 0x001F052C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildApplicationsEvent other)
		{
			return true;
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x001F233C File Offset: 0x001F053C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x001F234C File Offset: 0x001F054C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x001F235C File Offset: 0x001F055C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x001F236C File Offset: 0x001F056C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x001F237C File Offset: 0x001F057C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x001F238C File Offset: 0x001F058C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildApplicationsEvent other)
		{
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x001F239C File Offset: 0x001F059C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x001F23AC File Offset: 0x001F05AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x001F23BC File Offset: 0x001F05BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildApplicationsEvent()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 4:
					return;
				case 5:
					GuildApplicationsEvent._parser = new MessageParser<GuildApplicationsEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				GuildApplicationsEvent._repeated_applies_codec = FieldCodec.ForMessage<SocialApplicationInformation>(34U, OeGwygmLwyeIVI4T1DZs.XVInXhlssT(OeGwygmLwyeIVI4T1DZs.brlmLQUlYs9));
				num2 = 4;
			}
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x001F24AC File Offset: 0x001F06AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HAMlF5OHLVd6prBWjmuk()
		{
			return true;
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x001F24B4 File Offset: 0x001F06B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildApplicationsEvent I34OscOHWPTJagGpKTrt()
		{
			return null;
		}

		// Token: 0x040016FE RID: 5886
		private static readonly MessageParser<GuildApplicationsEvent> _parser;

		// Token: 0x040016FF RID: 5887
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001700 RID: 5888
		public const int OffsetFieldNumber = 1;

		// Token: 0x04001701 RID: 5889
		private long offset_;

		// Token: 0x04001702 RID: 5890
		public const int CountFieldNumber = 2;

		// Token: 0x04001703 RID: 5891
		private long count_;

		// Token: 0x04001704 RID: 5892
		public const int TotalFieldNumber = 3;

		// Token: 0x04001705 RID: 5893
		private long total_;

		// Token: 0x04001706 RID: 5894
		public const int AppliesFieldNumber = 4;

		// Token: 0x04001707 RID: 5895
		private static readonly FieldCodec<SocialApplicationInformation> _repeated_applies_codec;

		// Token: 0x04001708 RID: 5896
		private readonly RepeatedField<SocialApplicationInformation> applies_;

		// Token: 0x04001709 RID: 5897
		private static GuildApplicationsEvent Dc0ERaOH6p1BR6tSBCdu;
	}
}

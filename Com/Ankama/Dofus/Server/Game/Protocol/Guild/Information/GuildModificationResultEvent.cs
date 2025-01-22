using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x02000510 RID: 1296
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildModificationResultEvent : IMessage<GuildModificationResultEvent>, IMessage, IEquatable<GuildModificationResultEvent>, IDeepCloneable<GuildModificationResultEvent>, IBufferMessage
	{
		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06003E0F RID: 15887 RVA: 0x001EAC6C File Offset: 0x001E8E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildModificationResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06003E10 RID: 15888 RVA: 0x001EAC7C File Offset: 0x001E8E7C
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

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06003E11 RID: 15889 RVA: 0x001EAC8C File Offset: 0x001E8E8C
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

		// Token: 0x06003E12 RID: 15890 RVA: 0x001EAC9C File Offset: 0x001E8E9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildModificationResultEvent()
		{
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x001EACAC File Offset: 0x001E8EAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildModificationResultEvent(GuildModificationResultEvent other)
		{
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x001EACBC File Offset: 0x001E8EBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildModificationResultEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06003E15 RID: 15893 RVA: 0x001EACCC File Offset: 0x001E8ECC
		// (set) Token: 0x06003E16 RID: 15894 RVA: 0x001EACE0 File Offset: 0x001E8EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialGroupOperationResult Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SocialGroupOperationResult)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x001EACF0 File Offset: 0x001E8EF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x001EAD00 File Offset: 0x001E8F00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildModificationResultEvent other)
		{
			return true;
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x001EAD10 File Offset: 0x001E8F10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x001EAD20 File Offset: 0x001E8F20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x001EAD30 File Offset: 0x001E8F30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x001EAD40 File Offset: 0x001E8F40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x001EAD50 File Offset: 0x001E8F50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x001EAD60 File Offset: 0x001E8F60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildModificationResultEvent other)
		{
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x001EAD70 File Offset: 0x001E8F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x001EAD80 File Offset: 0x001E8F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x001EAD90 File Offset: 0x001E8F90
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildModificationResultEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					GuildModificationResultEvent._parser = new MessageParser<GuildModificationResultEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x001EAE74 File Offset: 0x001E9074
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NCi38gOTUnZNUiee8syJ()
		{
			return true;
		}

		// Token: 0x06003E23 RID: 15907 RVA: 0x001EAE7C File Offset: 0x001E907C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildModificationResultEvent h2CM4nOTvOeABhIx7YQf()
		{
			return null;
		}

		// Token: 0x04001583 RID: 5507
		private static readonly MessageParser<GuildModificationResultEvent> _parser;

		// Token: 0x04001584 RID: 5508
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001585 RID: 5509
		public const int ResultFieldNumber = 1;

		// Token: 0x04001586 RID: 5510
		private SocialGroupOperationResult result_;

		// Token: 0x04001587 RID: 5511
		private static GuildModificationResultEvent q3KcBCOTcnNN7jlIv4Bi;
	}
}

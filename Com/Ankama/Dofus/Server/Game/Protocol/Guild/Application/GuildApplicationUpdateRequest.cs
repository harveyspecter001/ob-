using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application
{
	// Token: 0x02000554 RID: 1364
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildApplicationUpdateRequest : IMessage<GuildApplicationUpdateRequest>, IMessage, IEquatable<GuildApplicationUpdateRequest>, IDeepCloneable<GuildApplicationUpdateRequest>, IBufferMessage
	{
		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06004194 RID: 16788 RVA: 0x001F0DA4 File Offset: 0x001EEFA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildApplicationUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06004195 RID: 16789 RVA: 0x001F0DB4 File Offset: 0x001EEFB4
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

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06004196 RID: 16790 RVA: 0x001F0DC4 File Offset: 0x001EEFC4
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

		// Token: 0x06004197 RID: 16791 RVA: 0x001F0DD4 File Offset: 0x001EEFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationUpdateRequest()
		{
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x001F0DE4 File Offset: 0x001EEFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationUpdateRequest(GuildApplicationUpdateRequest other)
		{
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x001F0DF4 File Offset: 0x001EEFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x0600419A RID: 16794 RVA: 0x001F0E04 File Offset: 0x001EF004
		// (set) Token: 0x0600419B RID: 16795 RVA: 0x001F0E14 File Offset: 0x001EF014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ApplyText
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

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x0600419C RID: 16796 RVA: 0x001F0E24 File Offset: 0x001EF024
		// (set) Token: 0x0600419D RID: 16797 RVA: 0x001F0E34 File Offset: 0x001EF034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GuildId
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

		// Token: 0x0600419E RID: 16798 RVA: 0x001F0E44 File Offset: 0x001EF044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600419F RID: 16799 RVA: 0x001F0E54 File Offset: 0x001EF054
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildApplicationUpdateRequest other)
		{
			return true;
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x001F0E64 File Offset: 0x001EF064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060041A1 RID: 16801 RVA: 0x001F0E74 File Offset: 0x001EF074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x001F0E84 File Offset: 0x001EF084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x001F0E94 File Offset: 0x001EF094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x001F0EA4 File Offset: 0x001EF0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x001F0EB4 File Offset: 0x001EF0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildApplicationUpdateRequest other)
		{
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x001F0EC4 File Offset: 0x001EF0C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x001F0ED4 File Offset: 0x001EF0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x001F0EE4 File Offset: 0x001EF0E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildApplicationUpdateRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				GuildApplicationUpdateRequest._parser = new MessageParser<GuildApplicationUpdateRequest>(() => null);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x001F0FC8 File Offset: 0x001EF1C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oPTirVOHey05Y4kUDdHS()
		{
			return true;
		}

		// Token: 0x060041AA RID: 16810 RVA: 0x001F0FD0 File Offset: 0x001EF1D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildApplicationUpdateRequest QTguS0OH32Bvd0EbG5Iv()
		{
			return null;
		}

		// Token: 0x040016AD RID: 5805
		private static readonly MessageParser<GuildApplicationUpdateRequest> _parser;

		// Token: 0x040016AE RID: 5806
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016AF RID: 5807
		public const int ApplyTextFieldNumber = 1;

		// Token: 0x040016B0 RID: 5808
		private string applyText_;

		// Token: 0x040016B1 RID: 5809
		public const int GuildIdFieldNumber = 2;

		// Token: 0x040016B2 RID: 5810
		private int guildId_;

		// Token: 0x040016B3 RID: 5811
		private static GuildApplicationUpdateRequest QBwmYAOHBJqDEkf56xR1;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Account
{
	// Token: 0x02000DEC RID: 3564
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuestModeEvent : IMessage<GuestModeEvent>, IMessage, IEquatable<GuestModeEvent>, IDeepCloneable<GuestModeEvent>, IBufferMessage
	{
		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x0600ABA8 RID: 43944 RVA: 0x0029AAB4 File Offset: 0x00298CB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuestModeEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x0600ABA9 RID: 43945 RVA: 0x0029AAC4 File Offset: 0x00298CC4
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

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x0600ABAA RID: 43946 RVA: 0x0029AAD4 File Offset: 0x00298CD4
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

		// Token: 0x0600ABAB RID: 43947 RVA: 0x0029AAE4 File Offset: 0x00298CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuestModeEvent()
		{
		}

		// Token: 0x0600ABAC RID: 43948 RVA: 0x0029AAF4 File Offset: 0x00298CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuestModeEvent(GuestModeEvent other)
		{
		}

		// Token: 0x0600ABAD RID: 43949 RVA: 0x0029AB04 File Offset: 0x00298D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuestModeEvent Clone()
		{
			return null;
		}

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x0600ABAE RID: 43950 RVA: 0x0029AB14 File Offset: 0x00298D14
		// (set) Token: 0x0600ABAF RID: 43951 RVA: 0x0029AB24 File Offset: 0x00298D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Effective
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

		// Token: 0x0600ABB0 RID: 43952 RVA: 0x0029AB34 File Offset: 0x00298D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600ABB1 RID: 43953 RVA: 0x0029AB44 File Offset: 0x00298D44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuestModeEvent other)
		{
			return true;
		}

		// Token: 0x0600ABB2 RID: 43954 RVA: 0x0029AB54 File Offset: 0x00298D54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600ABB3 RID: 43955 RVA: 0x0029AB64 File Offset: 0x00298D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600ABB4 RID: 43956 RVA: 0x0029AB74 File Offset: 0x00298D74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600ABB5 RID: 43957 RVA: 0x0029AB84 File Offset: 0x00298D84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600ABB6 RID: 43958 RVA: 0x0029AB94 File Offset: 0x00298D94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600ABB7 RID: 43959 RVA: 0x0029ABA4 File Offset: 0x00298DA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuestModeEvent other)
		{
		}

		// Token: 0x0600ABB8 RID: 43960 RVA: 0x0029ABB4 File Offset: 0x00298DB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600ABB9 RID: 43961 RVA: 0x0029ABC4 File Offset: 0x00298DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600ABBA RID: 43962 RVA: 0x0029ABD4 File Offset: 0x00298DD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuestModeEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					GuestModeEvent._parser = new MessageParser<GuestModeEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		// Token: 0x0600ABBB RID: 43963 RVA: 0x0029ACCC File Offset: 0x00298ECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YFR2VrJUJOeNfYEtktcp()
		{
			return true;
		}

		// Token: 0x0600ABBC RID: 43964 RVA: 0x0029ACD4 File Offset: 0x00298ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuestModeEvent B67ghtJUGjebP5yYJhpk()
		{
			return null;
		}

		// Token: 0x04003F03 RID: 16131
		private static readonly MessageParser<GuestModeEvent> _parser;

		// Token: 0x04003F04 RID: 16132
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F05 RID: 16133
		public const int EffectiveFieldNumber = 1;

		// Token: 0x04003F06 RID: 16134
		private bool effective_;

		// Token: 0x04003F07 RID: 16135
		private static GuestModeEvent d6fF0oJUOqPg1qixB3w5;
	}
}
